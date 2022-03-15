using System;
using EntityFramework.Model;
using System.Linq;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //For inserting the data

            //var db = new LearnEntityFrameworkCoreDB();
            //var product = new Product()
            //{
            //    Name = "Tivi 3",
            //    Price = 12,
            //    Quantity = 3,
            //    CreationDate = DateTime.Now,
            //    Status = true,
            //    CategoryId = 3
            //};
            //db.Products.Add(product);
            //Console.WriteLine("Result: " + db.SaveChanges());


            //For updating the data

            //var db = new LearnEntityFrameworkCoreDB();
            //var product = db.Products.SingleOrDefault(p => p.Id == 7);
            //product.Name = "abc";
            //product.Price = 999;
            //product.Status = false;

            //Console.WriteLine("Result: " + db.SaveChanges());


            //For deleting the data

            var db = new LearnEntityFrameworkCoreDB();
            var product = db.Products.SingleOrDefault(p => p.Id == 7);
            db.Products.Remove(product);

            Console.WriteLine("Result: " + db.SaveChanges());

            //For displaying the data


            //var db = new LearnEntityFrameworkCoreDB();
            //var avgprice = db.Products.Average(p => p.Price);
            //Console.WriteLine("Average Price is " + avgprice);
            //var max = db.Products.Max(p => p.Price);
            //Console.WriteLine("The biggest price is " + max);
            //var min = db.Products.Min(p => p.Price);
            //Console.WriteLine("The minimum price is " + min);
            //var products = db.Products.OrderByDescending(p => p.Price).Skip(0).Take(2).ToList();
            ////var products = db.Products.OrderBy(p => p.Price).ToList();
            ////var products = db.Products.Where(p => p.Name.EndsWith("top 1")).ToList();
            ////var products = db.Products.Where(p => p.Name.Contains("bi")).ToList();
            ////var products = db.Products.Where(p => p.Price >= 15 && p.Price <= 20).ToList();
            ////var products = db.Products.Where(p => p.CategoryId == 1 || p.CategoryId == 2).ToList();
            ////var products = db.Products.Where(p => p.Price > 22).ToList();
            ////var products = db.Products.Where(p => p.Status == true).ToList();
            //foreach (var product in products)
            //{
            //    Console.WriteLine("Id: " + product.Id);
            //    Console.WriteLine("Name: " + product.Name);
            //    Console.WriteLine("Price: " + product.Price);
            //    Console.WriteLine("Quantity: " + product.Quantity);
            //    Console.WriteLine("Status: " + product.Status);
            //    Console.WriteLine("CreationDate: " + product.CreationDate.ToString("MM/dd/yyy"));
            //    Console.WriteLine("Category Id: " + product.Category.Id);
            //    Console.WriteLine("Category Name: " + product.Category.Name);
            //    Console.WriteLine("==========================");
            //}

            Console.ReadLine();
        }
    }
}
