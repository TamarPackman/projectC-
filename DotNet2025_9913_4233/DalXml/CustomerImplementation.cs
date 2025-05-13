using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dal
{
    internal class CustomerImplementation : Icustomer
    {
     
        private string  filePath = @"..\xml\customers.xml";
        private  List<Customer> LoadCustomers()
        {
            if (!File.Exists(filePath))
                return new List<Customer>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (List<Customer>)serializer.Deserialize(fs);
            }
        }

        private  void SaveCustomers(List<Customer> customers)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, customers);
            }
        }
        public int Create(Customer item)
        {
            List<Customer> customers = LoadCustomers();
            if (customers.Any(c => c._idCard == item._idCard))
                throw new Exception("customer already exists");
            customers.Add(item);
            SaveCustomers(customers);
            return item._idCard;
        }

        public void Delete(int id)
        {
            List<Customer> customers = LoadCustomers();
            Customer? customer= customers.FirstOrDefault(c => c._idCard == id);
            if (customer == null)
                throw new DalNotFoundId("customer not found");
            customers.Remove(customer);
            SaveCustomers(customers);
        }

        public Customer? Read(int id)
        {
            List<Customer> customers = LoadCustomers();
            Customer ?customer = customers.FirstOrDefault(c => c._idCard == id);
            if (customer == null)
                throw new DalNotFoundId($"לקוח עם מזהה {id} לא נמצא");
            return customer;
        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            List<Customer> customers = LoadCustomers();
            if (filter == null)
                return customers; // אם לא הועבר סינון, מחזיר את הכל

            return customers.Where(filter).ToList(); // מחזיר רק את אלה שעונים על התנאי
        }

        public Customer? Read(Func<Customer, bool>? filter = null)
        {
            
                List<Customer> customers = LoadCustomers();
                if (filter == null)
                    return customers.FirstOrDefault();
                return customers.FirstOrDefault(filter);
        }

        
    

        public void Update(Customer item)
        {
            List<Customer> customers = LoadCustomers();
            int index = customers.FindIndex(c => c._idCard == item._idCard);
            if (index == -1)
                throw new DalNotFoundId("customer not found");
            customers[index] = item;
            SaveCustomers(customers);
        }

       
    }
}

