using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
namespace Dal
{
  
    public  class AppDbContext: DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DO.Product> Products { get; set; } // טבלה של מוצרים
        public DbSet<DO.Customer> Costumer { get; set; }
        public DbSet<DO.Sale> Sale { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer("Server=tami;Database=Cash register;Trusted_Connection=True;");
        //}
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // החיבור הוא חלק מהקוד שלך, תוכל להוסיף את חיבור ה-connection string מ-config
            var connectionString = "Data Source=tami;Initial Catalog=Cash register;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
