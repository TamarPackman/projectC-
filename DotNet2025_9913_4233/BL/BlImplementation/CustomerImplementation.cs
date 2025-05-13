using BlApi;
using DO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using BO;

namespace BlImplementation;

internal class CustomerImplementation : BlApi.ICustomers
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Customer c)
    {
        DO.Customer customerDo = new DO.Customer(c._idCard, c._phone, c._address, c._customerName);
        try
        {
            return _dal.Customer.Create(customerDo);
        }
        catch (DalIdExist exception)
        {
            throw new BlIdExist("id is exist",exception);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Customer.Delete(id);
        }
        catch (DalNotFoundId e)
        {
            throw new BlNotFoundId("id deant exist", e);
        }

    }

    

    public BO.Customer? Read(int id)
    {
        try
        {
            DO.Customer doCustomer = _dal.Customer.Read(id);
           
            return new BO.Customer(doCustomer._idCard, doCustomer._phone, doCustomer._address, doCustomer._customerName);
        }
        catch (DalNotFoundId exception) { throw new BlNotFoundId("id deant exist", exception); }

    }
    public bool isExistCustomer(int id)
    {
        BO.Customer  c= Read(id);
        if(c == null) return false;
        return true;

    }

    public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
    {
        List<DO.Customer> customersDo = _dal.Customer.ReadAll();
        List<BO.Customer> customersBo = customersDo.Select(c => new BO.Customer(c._idCard, c._phone, c._address, c._customerName))
        .ToList();

        if (filter == null)
            return customersBo;
        return customersBo.Where(filter).ToList();
    }

    public void Update(BO.Customer c)
    {
        try
        {
            _dal.Customer.Update(new DO.Customer(c._idCard, c._phone, c._address, c._customerName));
        }
        catch (DalIdExist e)
        {
            throw new BlIdExist("id is exist", e);
        }
        catch (DalNotFoundId e) { throw new BlNotFoundId("id deant exist", e); }
    }
    BO.Customer? ICustomers.Read(Func<BO.Customer, bool> filter)
    {
        List<BO.Customer> customersBo = ReadAll();
      return   customersBo.FirstOrDefault(c => filter(c));
    }

}