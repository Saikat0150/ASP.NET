using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InsertUpdateDeleteUsingMVC.Models
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> products { get; set; }
    }
}