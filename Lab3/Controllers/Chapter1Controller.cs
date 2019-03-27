using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class Chapter1Controller : Controller
    {
        // GET: Chapter
        public ActionResult Index()
        {
            var slide = new Slide
            {
                Number = 4,
                Name = "Chapter 1",
                Links = new List<Link>
                {
                    new Link()
                    {
                        LinkText = "Back to content",
                        ActionName = "Content",
                        ControllerName = "Home"
                    },

                    new Link()
                    {
                        LinkText = "Next slide",
                        ActionName = "InboundMarketStatistics",
                        ControllerName = "Chapter1"
                    }

                }
            };

            return View(slide);
        }

        public ActionResult InboundMarketStatistics()
        {
            var slide = new Slide
            {
                Number = 5,
                Name = "Chapter 1: Inbound market statistics",
                Links = new List<Link>
                {
                    new Link()
                    {
                        LinkText = "Go back to previous topic",
                        ActionName = "Index",
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
                        LinkText = "Next topic",
                        ActionName = "KeyInsights1",
                        ControllerName = "Chapter1"
                    }

                }
            };

            return View(slide);
        }

        public ActionResult KeyInsights1()
        {
            var slide = new Slide
            {
                Number = 6,
                Name = "Chapter 1.1: Key statistics",
                Links = new List<Link>
                {
                    new Link()
                    {
                        LinkText = "Go back to previous topic",
                        ActionName = "InboundMarketStatistics",
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
                        ControllerName = "Chapter2"
                    }

                }
            };

            return View(slide);
        }

    }
}