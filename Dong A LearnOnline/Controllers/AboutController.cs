using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Dong_A_LearnOnline.Controllers
{
    public class AboutController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
