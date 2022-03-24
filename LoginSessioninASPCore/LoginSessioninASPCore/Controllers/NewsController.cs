using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginSessioninASPCore.Controllers
{
    [Route("news")]
    public class NewsController : Controller
    {
        [Route("News")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
