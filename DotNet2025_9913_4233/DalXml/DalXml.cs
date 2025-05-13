using DalApi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DalXml : IDal
    {
        public static IDal Instance { get; } = new DalXml();
        public Icustomer Customer => new CustomerImplementation();

        public Iproduct Product =>  new ProductImplementation();

        public Isale Sale =>  new SaleImplementation();
    }
}
