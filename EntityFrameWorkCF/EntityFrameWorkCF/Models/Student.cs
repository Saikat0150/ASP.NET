using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWorkCF.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Moblile { get; set; }
        public double Salary { get; set; }
    }
}