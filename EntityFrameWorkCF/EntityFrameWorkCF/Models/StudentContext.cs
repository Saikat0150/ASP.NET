using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace EntityFrameWorkCF.Models
{
    public class StudentContext:DbContext
    {
        public DbSet<Student> students { get; set; }
    }
}