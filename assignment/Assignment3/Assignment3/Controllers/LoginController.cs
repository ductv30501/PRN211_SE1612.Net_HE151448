using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string email, string password)
        {
             email = Request.Query["email"];
             password = Request.Query["password"];
            Member member = null;
            using(var context = new FStoreContext())
            {
                member = context.Members.FirstOrDefault(member => member.Email.Equals(email) && member.Password.Equals(password));
            }

            if(member == null)
            {
                ViewData["Message"] = "Incorrect Email or Password!";
                return View();
            } else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
