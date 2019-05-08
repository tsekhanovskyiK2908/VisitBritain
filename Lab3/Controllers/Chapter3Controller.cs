using Lab3.Models;
using Lab3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class Chapter3Controller : Controller
    {
        private LinksHolder _linksHolder;

        public Chapter3Controller()
        {
            _linksHolder = new LinksHolder();
        }
        // GET: Chapter3
        public ActionResult Index()
        {
            var slide = new Slide
            {
                Number = 47,
                Name = "Chapter 3",
                Links = new List<Link>
                {
                    _linksHolder.Chapter2,
                    _linksHolder.Content,
                    _linksHolder.Main
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