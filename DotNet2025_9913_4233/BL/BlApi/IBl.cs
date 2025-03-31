﻿using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IBl
    {
     IProduct Product { get; }
        ICustomers Customer { get; }
        ISale Sale { get; }
        IOrder Order { get; }
    }
}
