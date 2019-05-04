using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class ToursController : Controller
    {

        private ApplicationDbContext _context;

        public ToursController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }

        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult New()
        {
            return View("TourForm", new Tour());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult Save(Tour tour)
        {   
            if(!ModelState.IsValid)
            {
                return View("TourForm", tour);
            }

            if (tour.Id == Guid.Empty)
            {
                _context.Tours.Add(tour);
            }
            else
            {
                var tourInDb = _context.Tours.Single(t => t.Id == tour.Id);
                tourInDb.Name = tour.Name;
                tourInDb.DepartureDate = tour.DepartureDate;
                tourInDb.DepartureCity = tour.DepartureCity;
                tourInDb.ArrivalDate = tour.ArrivalDate;
                tourInDb.ArrivalCity = tour.ArrivalCity;
                tourInDb.Price = tour.Price;
                tourInDb.PlaceNumber = tour.PlaceNumber;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Tours");
        }

        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult Edit(Guid id)
        {
            var tour = _context.Tours.SingleOrDefault(t => t.Id == id);

            if (tour == null)
            {
                return HttpNotFound();
            }

            return View("TourForm", tour);
        }

        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        //[HttpDelete]
        public ActionResult Delete(Guid id)
        {
            var tourInDb = _context.Tours.SingleOrDefault(t => t.Id == id);           

            if(tourInDb==null)
            {
                return HttpNotFound();
            }

            _context.Tours.Remove(tourInDb);
            _context.SaveChanges();

            return RedirectToAction("Index", "Tours");
        }
        // GET: Tour
        public ActionResult Index()
        {    
            if(User.IsInRole(RoleName.CanManageToursAndUsers))
            {
                return View("IndexForAdmin", _context.Tours.ToList());
            }

            return View("IndexForAll",_context.Tours.ToList());
        }
    }
}