using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Begin.Models;

namespace MVC_Begin.Controllers
{
    public class AccountController : Controller
    {
        ShopContext db;
        public AccountController(ShopContext shopContext)
        {
            db = shopContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
