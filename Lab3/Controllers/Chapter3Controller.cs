using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class Chapter3Controller : Controller
    {
        // GET: Chapter3
        public ActionResult Index()
        {
            var slide = new Slide
            {
                Number = 47,
                Name = "Chapter 3",
                Links = new List<Link>
                {
                    new Link()
                    {
                        LinkText = "Go back to previous chapter",
                        ActionName = "Index",
                        ControllerName = "Chapter2"
                    },

                    new Link()
                    {
                        LinkText = "Back to content",
                        ActionName = "Content",
                        ControllerName = "Home"
                    },

                    new Link()
                    {
                        LinkText = "Go to main",
                        ActionName = "Index",
                        ControllerName = "Home"
                    }

                }
            };

            return View(slide);
        }
    }
}