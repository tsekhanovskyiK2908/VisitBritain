﻿using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var slide = new Slide
            {   
                Name = "VisitBritain",
                Links = new List<Link>
                {
                    new Link()
                    {
                        LinkText = "Go to content",
                        ActionName = "Content",
                        ControllerName = "Home"
                    },

                    new Link()
                    {
                        LinkText = "Go to overview",
                        ActionName = "Overview",
                        ControllerName = "Home"
                    }

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
                    new Link()
                    {
                        LinkText = "Back to main",
                        ActionName = "Index",
                        ControllerName = "Home"
                    },

                    new Link()
                    {
                        LinkText = "Go to content",
                        ActionName = "Content",
                        ControllerName = "Home"
                    }

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
                    new Link()
                    {
                        LinkText = "Go to overview",
                        ActionName = "Overview",
                        ControllerName = "Home"
                    },

                    new Link()
                    {
                        LinkText = "Start the first chapter",
                        ActionName = "Index",
                        ControllerName = "Chapter1"
                    }

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