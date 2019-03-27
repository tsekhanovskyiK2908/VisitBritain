using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class Chapter2Controller : Controller
    {
        // GET: Chapter2
        public ActionResult Index()
        {
            var slide = new Slide
            {
                Number = 28,
                Name = "Chapter 2",
                Links = new List<Link>
                {
                    new Link()
                    {
                        LinkText = "Go back to previous topic",
                        ActionName = "KeyInsights1",
                        ControllerName = "Chapter1"
                    },

                    new Link()
                    {
                        LinkText = "Back to content",
                        ActionName = "Content",
                        ControllerName = "Home"
                    },

                    new Link()
                    {
                        LinkText = "Next chapter",
                        ActionName = "Index",
                        ControllerName = "Chapter3"
                    }

                }
            };

            return View(slide);
        }
    }
}