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
        private LinksHolder _linksHolder;

        public Chapter1Controller()
        {
            _linksHolder = new LinksHolder();
        }
        // GET: Chapter
        public ActionResult Index()
        {             

            var slide = new Slide
            {
                Number = 4,
                Name = "Chapter 1",
                Links = new List<Link>
                {
                    _linksHolder.Content,
                    _linksHolder.InboundMarketStatistics
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
                    _linksHolder.Chapter1,
                    _linksHolder.Content,
                    _linksHolder.KeyInsights
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
                    _linksHolder.InboundMarketStatistics,
                    _linksHolder.Content,
                    _linksHolder.Chapter2
                }
            };

            return View(slide);
        }

    }
}