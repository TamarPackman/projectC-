using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi;

public interface ICustomers
{
    int Create(BO.Customer c);
  BO.Customer? Read(int id);
    BO.Customer? Read(Func<BO.Customer, bool>? filter = null);
    List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null);
    void Update(BO.Customer c);
    void Delete(int id);
    bool isExistCustomer(int id);
}
