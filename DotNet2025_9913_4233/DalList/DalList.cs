using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed class DalList  : IDal
    {
        public static IDal Instance { get; } = new DalList();
        //public static DalList Instance()
        //{
        //    return instance;
        //}

        public  Icustomer Customer  => new CustomerImplementation();

      public   Iproduct Product => new ProductImplementation();
       
      public   Isale  Sale => new SaleImplementation ();
        private DalList()
        {

        }
    }
}
