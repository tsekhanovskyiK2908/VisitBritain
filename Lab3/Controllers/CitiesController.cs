using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab3.Models;
using Lab3.ViewModels;
using System.Web.Mvc;
using System.Data.Entity;

namespace Lab3.Controllers
{
    public class CitiesController : Controller
    {
        private ApplicationDbContext _context;

        public CitiesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult New()
        {
            var viewModel = new CityFormViewModel
            {
                City = new City(),
                Countries = _context.Countries.ToList(),
                CityStatuses = _context.CityStatuses.ToList()
            };

            return View("CityForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult Edit(Guid id)
        {
            var city = _context.Cities.SingleOrDefault(c => c.Id == id);

            if(city==null)
            {
                return HttpNotFound();
            }

            var viewModel = new CityFormViewModel
            {
                City = city,
                Countries = _context.Countries.ToList(),
                CityStatuses = _context.CityStatuses.ToList()
            };

            return View("CityForm",viewModel);
        }

        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult Save(City city)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new CityFormViewModel
                {
                    City = city,
                    Countries = _context.Countries.ToList(),
                    CityStatuses = _context.CityStatuses.ToList()
                };

                return View("CityForm", viewModel); 
            }

            var descriptionText = city.Description;

            if(city.Id == Guid.Empty)
            {
                city.Description = TxtDescriptionParser.WriteDescriptionOfCityToFile(city.Name, descriptionText);
                _context.Cities.Add(city);
            }
            else
            {
                var cityInDb = _context.Cities.Single(c => c.Id == city.Id);
                cityInDb.Name = city.Name;
                cityInDb.CityStatusId = city.CityStatusId;
                cityInDb.CountryId = city.CountryId;
                cityInDb.Description = TxtDescriptionParser.WriteDescriptionOfCityToFile(city.Name, descriptionText);

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Cities");
        }

        public ActionResult Delete(Guid id)
        {
            var city = _context.Cities.SingleOrDefault(c => c.Id == id);

            if(city==null)
            {
                return HttpNotFound();
            }

            _context.Cities.Remove(city);
            _context.SaveChanges();

            return RedirectToAction("Index", "Cities");
        }

        public ActionResult Details(Guid id)
        {
            var city = _context.Cities.Include(c => c.Country).Include(c => c.CityStatus).SingleOrDefault(c => c.Id == id);
            city.Description = TxtDescriptionParser.ReadDescriptionOfCity(city.Name);

            if(city==null)
            {
                return HttpNotFound();
            }

            return View(city);
        }

        // GET: Cities
        public ActionResult Index()
        {
            var cities = _context.Cities.Include(c => c.CityStatus).Include(c => c.Country).ToList();

            foreach (var city in cities)
            {
                city.Description = TxtDescriptionParser.ReadDescriptionOfCity(city.Name);
            }

            if(User.IsInRole(RoleName.CanManageToursAndUsers))
            {
                return View("IndexForAdmin",cities);
            }

            return View("IndexForAll", cities);
        }
    }
}