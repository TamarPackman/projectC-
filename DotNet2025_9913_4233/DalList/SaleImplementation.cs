﻿
using DO;
using DalApi;
using System.Reflection;
using Tools;

namespace Dal;

internal class SaleImplementation: Isale
{
  public  int Create(Sale item)
    {
        Sale s = item with { id = DataSource.Config.StaticId };
        if (DataSource.sales.Any(sale => sale.id == s.id))
            throw new DalIdExist("⚠️ שגיאה: לא ניתן להוסיף את המבצע. מבצע עם אותם פרטים כבר קיים במערכת.\r\nאנא בדוק את הנתונים ונסה שוב או צור קשר עם התמיכה הטכנית.");
        DataSource.sales.Add(s);
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המבצע נוצר בהצלחה");
        return item._productId;

    }
  public  Sale? Read(int id)
    {
        Sale s= DataSource.sales.FirstOrDefault(item => item._productId == id);
        if (s != null)
        {
            LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המבצע נקרא בהצלחה");
            return s;
        }

            throw new DalNotFoundId("פג תוקף המבצע");


    }
  public  Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המבצע נקרא בהצלחה");
        return DataSource.sales.FirstOrDefault(filter);


    }
  public   List<Sale> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המבצעים נקרא בהצלחה");
        if (filter == null)
            return DataSource.sales;
        return DataSource.sales.Where((c) => filter(c)).ToList();
    }
    public  void Update(Sale item)
    {
        if(Read(item._productId)!=null)
            Delete(item._productId);
        else
            Create(item);
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המבצע התעדכן בהצלחה");


    }
 public   void Delete(int id)
    {
        if(Read(id) != null)
            DataSource.sales.Remove(Read(id));
        LogManager.writeToLog("DalList", MethodBase.GetCurrentMethod().DeclaringType.FullName, "המבצע נמחק בהצלחה");

    }

    
}

