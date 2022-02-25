using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HelloMVC.Models
{
    public class MyDataContext : DbContext
    {
        public MyDataContext():base("name=MyConnectionString")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}