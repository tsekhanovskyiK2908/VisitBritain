using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
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

        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult New()
        {
            var viewModel = new OrderFormViewModel
            {
                TourOfCustomer = new TourOfCustomer(),
                ApplicationUsers = _context.Users.ToList(),
                Tours = _context.Tours.ToList()
            };

            return View("OrderForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult Edit(Guid id)
        {
            var tourOfCustomer = _context.ToursOfCustomers.SingleOrDefault(t => t.Id == id);            

            if (tourOfCustomer == null)
            {
                return HttpNotFound();
            }

            var currentUser = _context.Users.SingleOrDefault(u => u.Id == tourOfCustomer.CustomerId);

            var listForCurrentUser = new List<ApplicationUser>
            {
                currentUser
            };

            var viewModel = new OrderFormViewModel
            {
                TourOfCustomer = tourOfCustomer,
                ApplicationUsers = listForCurrentUser,
                Tours = _context.Tours.ToList()
            };

            return View("OrderForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult Save(TourOfCustomer tourOfCustomer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new OrderFormViewModel
                {
                    TourOfCustomer = tourOfCustomer,
                    ApplicationUsers = _context.Users.ToList(),
                    Tours = _context.Tours.ToList()
                };

                return View("OrderForm", tourOfCustomer);
            }

            var tourInDb = _context.Tours.SingleOrDefault(t => t.Id == tourOfCustomer.TourId); 

            if (tourOfCustomer.Id == Guid.Empty)
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


                if (tourInDb.Id != tourOfCustomerInDb.TourId)
                {
                    tourInDb.PlaceNumber--;
                    var tourInDbPrevious = _context.Tours.SingleOrDefault(t => t.Id == tourOfCustomerInDb.TourId);
                    tourInDbPrevious.PlaceNumber++;
                }

                tourOfCustomerInDb.TourId = tourOfCustomer.TourId;
                tourOfCustomerInDb.SoldDate = DateTime.Now;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Orders");
        }

        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult Delete(Guid id)
        {
            var tourOfCustomerInDb = _context.ToursOfCustomers.SingleOrDefault(t => t.Id == id);
            var tourInDb = _context.Tours.SingleOrDefault(t => t.Id == tourOfCustomerInDb.TourId);

            if (tourOfCustomerInDb == null)
            {
                return HttpNotFound();
            }

            tourInDb.PlaceNumber++;
            _context.ToursOfCustomers.Remove(tourOfCustomerInDb);
            _context.SaveChanges();

            return RedirectToAction("Index", "Orders");
        }

        // GET: Orders
        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult Index()
        {
            var toursOfCustomers = _context.ToursOfCustomers.Include(t => t.Customer).Include(t => t.Tour).ToList();
            return View("IndexForAdmin",toursOfCustomers);
        }
    }
}