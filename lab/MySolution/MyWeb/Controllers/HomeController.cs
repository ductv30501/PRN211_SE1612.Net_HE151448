using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            HomeModel message = new HomeModel();
            return View(message);
        }

    }
}
