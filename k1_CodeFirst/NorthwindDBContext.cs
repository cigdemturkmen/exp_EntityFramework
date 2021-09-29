using k1_CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_CodeFirst
{
    public class NorthwindDBContext : DbContext
    {
        public NorthwindDBContext()
        {
            //this.Database.Connection.ConnectionString = "Server= 192.168.187.171,1433; Database=Northwind; User Id =cigdem ; Password =Password1;";

            this.Database.Connection.ConnectionString = "Data Source = 192.168.187.171,1433; Initial Catalog = Northwind;  Network Library = DBMSLPCN; User ID = cigdem; Password = Password1;";

            //this.Database.Connection.ConnectionString = "Server= 192.168.187.171; Database=Northwind; Trusted_Connection=Yes;";

            //this.Database.Connection.ConnectionString = "Data Source = 192.168.187.171,1433; Network Library = DBMSSOCN; Initial Catalog = myDataBase; User ID = myUsername; Password = myPassword;";

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
