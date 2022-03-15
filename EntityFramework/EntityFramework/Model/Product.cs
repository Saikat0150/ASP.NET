using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using EntityFramework.Model;

namespace EntityFramework.Model
{
    [Table("Product")]
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
