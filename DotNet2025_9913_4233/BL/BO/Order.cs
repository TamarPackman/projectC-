using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

public class  Order
{
   public bool FavoriteCustomer { get; set; }
 public   List<ProductInOrder> ProductList { get; set; }
  public   double FinalPrice { get; set; }
    public Order() 
    {

    }
    public Order(bool favoriteCustomer,List<ProductInOrder> productList, double finalPrice)
    {
        this.FavoriteCustomer = favoriteCustomer;
        this.ProductList = productList;
        this.FinalPrice = finalPrice;
    }
    public Order(bool favoriteCustomer)
    {
        this.FavoriteCustomer = favoriteCustomer;

        this.ProductList = new List<ProductInOrder>();
    }

    public override string ToString() => Tools.ToStringProperty(this);
}