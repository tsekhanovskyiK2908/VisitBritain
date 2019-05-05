using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab3.Models;

namespace Lab3.Controllers
{
    public class OrdersController : Controller
    {
        private ApplicationDbContext _context;

        public OrdersController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult New()
        {
            return View("OrderForm");
        }

        public ActionResult Create(ToursOfCustomer tourOfCustomer)
        {
            if(!ModelState.IsValid)
            {
                return View("OrderForm", tourOfCustomer);
            }



            return RedirectToAction("Index", "Orders");
        }

        // GET: Orders
        public ActionResult Index()
        {
            return View();
        }
    }
}