using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_First_Approch_EntityFramwwork
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var cont=new Learn_EntityFrameworkEntities())
            {
                var result = cont.Products;
                foreach(var item in result)
                {
                    Console.WriteLine("Product ID: " + item.Id);
                    Console.WriteLine("Product Name: " + item.Name);
                    Console.WriteLine("Product Price: " + item.Price);
                    Console.WriteLine("Product Quantity: " + item.Quantity);
                    Console.Read();
                }
            }
        }
    }
}
