using FormsValidationUsingMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormsValidationUsingMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Account account)
        {
            // Custom validation
            if (account.Username != null && account.Username.Equals("abc123"))
            {
                ModelState.AddModelError("Username", "Username already exists");
            }
            if (ModelState.IsValid)
            {
                ViewBag.account = account;
                return View("Success");
            }
            return View("Index");
        }

    }
}