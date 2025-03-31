using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

public record ProductInOrder
{ 

  public int productInOrderId { get; set; }
 public    string productName { get; set; }
 public    double basePrice { get; set; }
 public    int quantity { get; set; }
    public List<SaleInProduct> saleList { get; set; }
    public double finalPrice { get; set; }


    public ProductInOrder()
    {
        
    }
    public ProductInOrder(int productInOrderId, string productName, double basePrice, int quantity, double finalPrice)
    {
       this. productInOrderId = productInOrderId;
       this. productName = productName;
       this. basePrice = basePrice;
       this. quantity = quantity;
        saleList = new List<SaleInProduct>(); // אתחול של SaleList
    }
    public override string ToString() => Tools.ToStringProperty(this);

}