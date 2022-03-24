using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginSessioninASPCore.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
