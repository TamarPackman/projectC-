using BlApi;
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{

    internal class ProductImplementation:BlApi.IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Product c)
        {
            DO.Product productDo = new DO.Product(c._id,
           c._nameProduct,
            (DO.CategoryName)(int)c._category,
            c._price,
              c._quantityInStock);
            try
            {
                return _dal.Product.Create(productDo);
            }
            catch (DalIdExist exception)
            {
                throw new BlIdExist("id is exist", exception);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Product.Delete(id);
            }
            catch (DalNotFoundId e)
            {
                throw new BlNotFoundId("id deasnt exist", e);
            }

        }


        public BO.Product? Read(int id)
        {
            try
            {
                DO.Product? doProducts = _dal.Product.Read(id);
                if (doProducts == null)
                    return null;
                return new BO.Product(doProducts._id,
     doProducts._nameProduct,
   (BO.CategoryName)(int)doProducts._category,
     doProducts._price,
    doProducts._quantityInStock
    );
            }
            catch (DalNotFoundId e) { throw new BlNotFoundId("id deant exist", e); }

        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            List<DO.Product> productsDo = _dal.Product.ReadAll();
            List<BO.Product> productsBo = productsDo.Select(p => new BO.Product(p._id,
     p._nameProduct,
   (BO.CategoryName)(int)p._category,
     p._price,
    p._quantityInStock))
            .ToList();
            if (filter == null)
                return productsBo;
            return productsBo.Where(filter).ToList();
        }

        public void Update(BO.Product p)
        {
            try
            {
                _dal.Product.Update(new DO.Product(p._id,
     p._nameProduct,
   (DO.CategoryName)(int)p._category,
     p._price,
    p._quantityInStock));
            }
            catch (DalIdExist e)
            {
                throw new BlIdExist("id is exist", e);
            }
            catch (DalNotFoundId e) { throw new BlNotFoundId("id deasnt exist", e); }
        }

       void  IProduct.activeSales(ProductInOrder productInOrder,bool favoriteCustomer)
        {

            productInOrder.saleList = _dal.Sale.ReadAll(s => s._productId == productInOrder.productInOrderId && s._dateStartSale <= DateTime.Now && s._dateEndSale >= DateTime.Now && s._quantityForSale <= productInOrder.quantity && (favoriteCustomer || (s._isForClubMembersOnly == true)))
                    .Select(s => new SaleInProduct(s.id, s._quantityForSale , s._salePrice, s._isForClubMembersOnly )).OrderBy(x => x.Price / x.quantityForSale).ToList();
            
        }
        BO.Product? IProduct.Read(Func<BO.Product, bool> filter)
        {
            List<BO.Product> productsBo = ReadAll();
            BO. Product? p= productsBo.FirstOrDefault(c => filter(c));
            if (p != null)
                return p;
            else
                throw new BlNotFoundId("id deasnt exist");

        }
        
    }
}
