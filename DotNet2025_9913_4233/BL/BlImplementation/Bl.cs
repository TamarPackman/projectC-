
using BlApi;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class Bl:BlApi.IBl
    {
        public ICustomers Customer =>new CustomerImplementation();
        public IOrder Order =>new OrderImplementation();
        public IProduct Product =>new ProductImplementation();   
        public ISale Sale => new SaleImplementation();
     
    }
}
