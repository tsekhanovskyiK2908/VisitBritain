using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        private LinksHolder _linksHolder;

        public HomeController()
        {
            _linksHolder = new LinksHolder();
        }
        public ActionResult Index()
        {
            var slide = new Slide
            {   
                Name = "VisitBritain",
                Links = new List<Link>
                {
                    _linksHolder.Content,
                    _linksHolder.Overview
                }
            };

            return View(slide);
        }

        public ActionResult Overview()
        {
            var slide = new Slide
            {
                Number = 2,
                Name = "Overview",
                Links = new List<Link>
                {
                    _linksHolder.Main,
                    _linksHolder.Content
                }
            };

            return View(slide);
        }

        public ActionResult Content()
        {
            var slide = new Slide
            {   
                Number = 3,
                Name = "Content",
                Links = new List<Link>
                {
                    _linksHolder.Overview,
                    _linksHolder.Chapter1
                }
            };

            return View(slide);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}