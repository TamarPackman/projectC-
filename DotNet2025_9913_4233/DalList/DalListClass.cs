using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed class DalListClass  : IDal
    {
        private static readonly DalListClass instance=new DalListClass();
        public static DalListClass Instance()
        {
            return instance;
        }

      public  Icustomer Customer  => new CustomerImplementation();

      public   Iproduct Product => new ProductImplementation();
       
      public   Isale  Sale => new SaleImplementation ();
        private DalListClass()
        {

        }
    }
}
