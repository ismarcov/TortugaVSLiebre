using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class CarreraController : Controller
    {
        public IActionResult Index()
        {
            return View("Carrera");
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //return "Welcome action boiiiiii";
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

                
    }
}

