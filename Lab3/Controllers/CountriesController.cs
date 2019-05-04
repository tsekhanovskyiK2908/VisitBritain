using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class CountriesController : Controller
    {
        private ApplicationDbContext _context;

        public CountriesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Countries
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageToursAndUsers))
            {
                return View("IndexForAdmin", _context.Countries.ToList());
            }

            return View("IndexForAll", _context.Countries.ToList());
        }

        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult Delete(Guid id)
        {
            var countryInDb = _context.Countries.SingleOrDefault(c => c.Id == id);

            if(countryInDb == null)
            {
                return HttpNotFound();
            }

            _context.Countries.Remove(countryInDb);
            _context.SaveChanges();

            return RedirectToAction("Index", "Countries");
        }

        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult New()
        {
            return View("CountryForm", new Country());
        }

        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult Edit(Guid id)
        {
            var country = _context.Countries.SingleOrDefault(c => c.Id == id);

            if (country == null)
            {
                return HttpNotFound();
            }

            return View("CountryForm", country);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult Save(Country country)
        {

            if (!ModelState.IsValid)
            {
                return View("CountryForm");
            }

            if (country.Id == Guid.Empty)
            {
                _context.Countries.Add(country);
            }
            else
            {
                var countryInDb = _context.Countries.Single(c => c.Id == country.Id);
                countryInDb.Name = country.Name;
                countryInDb.Language = country.Language;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Countries");
        }
    }
}