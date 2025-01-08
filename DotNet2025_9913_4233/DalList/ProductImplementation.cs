using DO;
using DalApi;
using System.Reflection;
using Tools;

namespace Dal;

internal class ProductImplementation:Iproduct
{
    public int Create(Product item)
    {
        if (DataSource.products.Any(product => product._id == item._id))
        {
            throw new DalIdExist("⚠️ שגיאה: לא ניתן להוסיף את המוצר. מוצר עם אותם פרטים כבר קיים במערכת.\r\nאנא בדוק את הנתונים ונסה שוב או צור קשר עם התמיכה הטכנית.");

        }
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המוצר התוסף בהצלחה");

        DataSource.products.Add(item);
        return item._id;

    }
    public Product? Read(int id)
    {
        Product p = DataSource.products.FirstOrDefault(item => item._id == id);
        if (p != null)
        {
            return p;
            LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המוצר נקרא בהצלחה");
        }
           


       
        throw new DalNotFoundId("מוצר זה לא קיים");
    }
  public  Product? Read(Func<Product, bool> filter)
    {
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המוצר נקרא בהצלחה");
        return DataSource.products.FirstOrDefault(filter);


    }
  public List<Product> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המוצרים נקראו בהצלחה");
        if (filter == null)
            return DataSource.products;
        return DataSource.products.Where((c) => filter(c)).ToList();
    }
    public void Update(Product item)
    {
        if (Read(item._id) != null)
        {
            Delete(item._id);
            Create(item);
            LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המוצר התעדכן בהצלחה");
        }
    }
    public void Delete(int id)
    {
        if (Read(id) != null)
        {
            DataSource.products.Remove(Read(id));
            LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המוצר נמחק בהצלחה");
        }
    }
}
