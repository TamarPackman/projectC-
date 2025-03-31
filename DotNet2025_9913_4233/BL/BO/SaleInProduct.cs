using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

public record SaleInProduct
(

   int saleId,
   int quantityForSale,
   double Price,
  bool isSaleForAllCustomers
)
{

    public SaleInProduct() : this(0, 0,  0,false)
    {

    }


    public override string ToString() => Tools.ToStringProperty(this);


}