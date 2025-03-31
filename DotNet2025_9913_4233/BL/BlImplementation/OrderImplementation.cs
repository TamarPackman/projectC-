using BlApi;
using BO;
using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation;

internal class OrderImplementation : BlApi.IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public void SearchSaleForProduct(ProductInOrder productInOrder,bool favoriteCustomer)
    {
        _dal.Sale.ReadAll().ForEach(sale => Console.WriteLine(sale))
           
        ;

        List<DO.Sale> saleList =_dal.Sale.ReadAll(s =>
     s._productId == productInOrder.productInOrderId &&
     s._dateStartSale <= DateTime.Now &&  //מבצע התחיל או כבר בתוקף
     s._dateEndSale >= DateTime.Now &&    //מבצע עדיין לא הסתיים
     productInOrder.quantity >= s._quantityForSale &&  //הכמות בהזמנה מספיקה
     (s._isForClubMembersOnly?favoriteCustomer:true)    //תנאי למבצע
 )
 .OrderBy(s => s._salePrice / s._quantityForSale) // מיון לפי מחיר ליחידה
 .ToList();
      
        productInOrder.saleList = saleList.Select(s => new SaleInProduct(s.id, s._quantityForSale, (int)s._salePrice, s._isForClubMembersOnly)).ToList();

       
       

    }

    public void CalcTotalPriceForProduct(ProductInOrder productInOrder)
    {
        //List<BO.SaleInProduct>mySales=new List<SaleInProduct>();
        int count = 0;
        if (productInOrder.saleList.ToArray().Length == 0)
        {
            productInOrder.finalPrice = productInOrder.basePrice * productInOrder.quantity;
        }
        else
        {
            count = productInOrder.quantity;


            foreach (var item in productInOrder.saleList)
            {
                if (count == 0)
                    break;
                if (count >= item.quantityForSale)
                {
                    int amount = count / item.quantityForSale;
                    count = count % item.quantityForSale;
                    //mySales.Add(item);
                    productInOrder.finalPrice += (amount * item.quantityForSale * productInOrder.basePrice) - amount * item.Price;
                }
                Console.WriteLine(count + "count");
            }
            if (count != 0)
                productInOrder.finalPrice += count * productInOrder.basePrice;
            Console.WriteLine(productInOrder.finalPrice);

          
        }
    
    }
    public void CalcTotalPrice(Order order)
    {
        double totalPrice = 0;
        order.ProductList.ForEach((p) => {  totalPrice += p.finalPrice; });
            order.FinalPrice= totalPrice;

    }
    public List<BO.SaleInProduct>AddProductToOrder(BO.Order order, int productId, int quantity)
    {
        if (quantity<=0)
            throw new BlInvalidQuantityException( "not valid quantity");
            DO.Product product;
        try
        {
            product = _dal.Product.Read(productId);
        }
        catch(DalNotFoundId exception) {
            throw new BlNotFoundId("id deasnt exist", exception);
        }

      ProductInOrder productInOrder=order.ProductList.FirstOrDefault(p=>p.productInOrderId == productId);
 
        if(productInOrder != null)
        {
            if (productInOrder.quantity + quantity > product._quantityInStock)
                throw new BlOutOfStockException("there arent enough products in stock 😒");

            productInOrder.quantity += quantity;
        }
        else
        {
            if(quantity>product._quantityInStock)
                throw new BlOutOfStockException("there arent enough products in stock 😒");
            productInOrder = new ProductInOrder(product._id, product._nameProduct, product._price,quantity,0);
            order.ProductList.Add(productInOrder);
        }
        SearchSaleForProduct(productInOrder, order.FavoriteCustomer);
        CalcTotalPriceForProduct(productInOrder);
        CalcTotalPrice(order);
        return productInOrder.saleList;
    }
    public void DoOrder(Order order)
    {
        order.ProductList.ForEach((p) =>
        {
            try
            {
                DO.Product product = _dal.Product.Read(p.productInOrderId);
                int quantity = product._quantityInStock;
                DO.Product updatedProduct = product with { _quantityInStock = quantity - p.quantity };
                _dal.Product.Update(updatedProduct);
            }
            catch(DalNotFoundId exception)
            {
                throw new BlNotFoundId("id deasnt exist", exception);
            }
         
        
        });
       
    }

   

   

   
}
