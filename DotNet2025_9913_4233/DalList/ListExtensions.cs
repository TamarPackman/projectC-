using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Dal
{
    public static class ListExtensions
    {
        public static void AddWithDb<T>(this List<T> list, T item) where T : class
        {
            // הוספת הפריט לרשימה
            list.Add(item);

            // הוספת הפריט לבסיס הנתונים
            //using (var context = new AppDbContext())
            //{
            //    var dbSet = context.Set<T>();

            //    // הוספת האובייקט לטבלה
            //    dbSet.Add(item);

            //    // שמירה בבסיס הנתונים
            //    context.SaveChanges();

            //}
        }
        public static void UpdateDb<T>(this List<T> list, T item) where T : class
        {


            //// הוספת הפריט לבסיס הנתונים
            //using (var context = new AppDbContext())
            //{
            //    var dbSet = context.Set<T>();

            //    // הוספת האובייקט לטבלה
            //    dbSet.Update(item);

            //    // שמירה בבסיס הנתונים
            //    context.SaveChanges();

            //}
        }
        public static void DeleteDb<T>(this List<T> list, T item) where T : class
        {
            list.Remove(item);
        
            //using (var context = new AppDbContext())
            //{
            //    var dbSet = context.Set<T>();

              
            //    dbSet.Remove(item);

              
            //    context.SaveChanges();

            //}
        }

    }
}
