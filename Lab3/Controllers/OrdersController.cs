using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab3.Models;
using Lab3.ViewModels;

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
            var viewModel = new OrderFormViewModel
            {
                TourOfCustomer = new TourOfCustomer(),
                ApplicationUsers = _context.Users.ToList(),
                Tours = _context.Tours.ToList()
            };

            return View("OrderForm");
        }

        public ActionResult Edit(Guid id)
        {
            var tourOfCustomers = _context.ToursOfCustomers.SingleOrDefault(t => t.Id == id);

            var currentUser = _context.Users.SingleOrDefault(u => new Guid(u.Id) == tourOfCustomers.CustomerId);

            var listForCurrentUser = new List<ApplicationUser>
            {
                currentUser
            };

            if (tourOfCustomers == null)
            {
                return HttpNotFound();
            }

            var viewModel = new OrderFormViewModel
            {
                TourOfCustomer = tourOfCustomers,
                ApplicationUsers = listForCurrentUser,
                Tours = _context.Tours.ToList()
            };

            return View("OrderForm", viewModel);
        }

        public ActionResult Create(TourOfCustomer tourOfCustomer)
        {
            if(!ModelState.IsValid)
            {
                return View("OrderForm", tourOfCustomer);
            }

            var tourInDb = _context.Tours.SingleOrDefault(t => t.Id == tourOfCustomer.TourId); //new selected

            if(tourOfCustomer.Id == Guid.Empty)
            {
                tourOfCustomer.SoldDate = DateTime.Now;
                tourInDb.PlaceNumber--;
                _context.ToursOfCustomers.Add(tourOfCustomer);
            }
            else
            {
                var tourOfCustomerInDb = _context
                    .ToursOfCustomers
                    .Single(t => t.Id == tourOfCustomer.Id);


               if(tourInDb.Id!=tourOfCustomerInDb.TourId)
               {
                    tourInDb.PlaceNumber--;
                    var tourInDbPrevious = _context.Tours.SingleOrDefault(t => t.Id == tourOfCustomerInDb.TourId);
                    tourInDbPrevious.PlaceNumber++;
               }

                tourOfCustomerInDb.TourId = tourOfCustomer.Id;
                tourOfCustomerInDb.SoldDate = DateTime.Now;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Orders");
        }

        // GET: Orders
        public ActionResult Index()
        {
            return View();
        }
    }
}