using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Begin.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace MVC_Begin.Controllers
{
    public class HomeController : Controller
    {

        public ShopContext db { set; get; }
        public List<User> users { set; get; }

        public HomeController(ShopContext shopContext)
        {
            db = shopContext;


        }
    
        public IActionResult Index()
        {
            return View(db.Phones.ToList());
        }
        [HttpGet]
        public IActionResult Buy(int? id, int? userId)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.PhoneId = id;
            ViewBag.UserId = userId;
            ViewBag.Users = db.Users.ToList();
            return View();
        }
        [HttpPost]
        public string Buy(int phoneId, int userId)
        {
            Order order = new Order();
            order.PhoneId = phoneId;
            order.UserId = userId;
            db.Orders.Add(order);

            db.SaveChanges();
            return "Спасибо за покупку"; 
        }
        /*
        public IActionResult Privacy()
        {
            return View();
        }
        */
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
