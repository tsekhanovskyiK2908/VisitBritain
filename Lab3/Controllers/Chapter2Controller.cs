using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab3.ViewModels;

namespace Lab3.Controllers
{
    public class Chapter2Controller : Controller
    {
        private LinksHolder _linksHolder;

        public Chapter2Controller()
        {
            _linksHolder = new LinksHolder();
        }

        // GET: Chapter2
        public ActionResult Index()
        {
            var slide = new Slide
            {
                Number = 28,
                Name = "Chapter 2",
                Links = new List<Link>
                {
                    _linksHolder.KeyInsights,
                    _linksHolder.Content,
                    _linksHolder.Chapter3
                }
            };

            var viewModel = new SlideAndSlideWithListsViewModel
            {
                Slide = slide
            };

            return View(viewModel);
        }
    }
}