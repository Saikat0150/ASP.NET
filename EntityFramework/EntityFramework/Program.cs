using System;
using EntityFramework.Model;
using System.Linq;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new LearnEntityFrameworkCoreDB();
            var avgprice = db.Products.Average(p => p.Price);
            Console.WriteLine("Average Price is " + avgprice);
            var max = db.Products.Max(p => p.Price);
            Console.WriteLine("The biggest price is " + max);
            var min = db.Products.Min(p => p.Price);
            Console.WriteLine("The minimum price is " + min);
            var products = db.Products.OrderByDescending(p => p.Price).Skip(0).Take(2).ToList();
            //var products = db.Products.OrderBy(p => p.Price).ToList();
            //var products = db.Products.Where(p => p.Name.EndsWith("top 1")).ToList();
            //var products = db.Products.Where(p => p.Name.Contains("bi")).ToList();
            //var products = db.Products.Where(p => p.Price >= 15 && p.Price <= 20).ToList();
            //var products = db.Products.Where(p => p.CategoryId == 1 || p.CategoryId == 2).ToList();
            //var products = db.Products.Where(p => p.Price > 22).ToList();
            //var products = db.Products.Where(p => p.Status == true).ToList();
            foreach (var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price: " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Status: " + product.Status);
                Console.WriteLine("CreationDate: " + product.CreationDate.ToString("MM/dd/yyy"));
                Console.WriteLine("Category Id: " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
                Console.WriteLine("==========================");
            }
            Console.ReadLine();
        }
    }
}
