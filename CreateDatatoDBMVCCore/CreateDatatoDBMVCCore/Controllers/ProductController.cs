using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CreateDatatoDBMVCCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateDatatoDBMVCCore.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private DataContext db;
        public ProductController(DataContext _db)
        {
            db = _db;
        }
        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.products = db.Products.ToList();
            return View();
        }
        [Route("add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [Route("add")]
        [HttpPost]
        public IActionResult Add(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("edit")]
        [HttpGet]
        public IActionResult Edit()
        {
            return View("Edit");
        }
        [Route("edit")]
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("delete")]
        [HttpGet]
        public IActionResult Delete()
        {
            return View("Delete");
        }
        [Route("delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            db.Products.Remove(db.Products.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
