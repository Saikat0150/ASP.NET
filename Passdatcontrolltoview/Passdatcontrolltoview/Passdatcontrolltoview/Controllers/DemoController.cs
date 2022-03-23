using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Passdatcontrolltoview.Models;
namespace Passdatcontrolltoview.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}


        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            //ViewBag.age = 20;
            //ViewBag.fullName = "Kevin";
            //ViewBag.status = true;
            //ViewBag.price = 4.5;
            //ViewBag.birthday = DateTime.Now;
            //return View();
            var products = new List<Product>
            {
                new Product
                {
                Id = "p01",
                Name = "Name1",
                Photo = "thumb1.jpg",
                Price = 5.5,
                Quantity = 4
            },
            new Product
            {
                Id = "p02",
                Name = "Name2",
                Photo = "thumb1.jpg",
                Price = 7,
                Quantity = 3
            },
            new Product
            {
                Id = "p03",
                Name = "Name3",
                Photo = "thumb1.jpg",
                Price = 8,
                Quantity = 6

            }
            };
            ViewBag.products = products;
            return View();
            }
        }
    }

