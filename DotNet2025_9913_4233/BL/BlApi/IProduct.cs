﻿using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BlApi;
public interface IProduct
{
    int Create(BO.Product c);
    BO.Product? Read(int id);
    List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null);
    void Update(BO.Product c);
    void Delete(int id);
    BO.Product? Read(Func<BO.Product, bool> filter);
    void  activeSales(ProductInOrder productInOrder, bool favoriteCustomer);
}
