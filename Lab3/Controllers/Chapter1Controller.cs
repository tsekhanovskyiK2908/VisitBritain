using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab3.ViewModels;

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

            var viewModel = new SlideAndSlideWithListsViewModel
            {
                Slide = slide
            };

            return View(viewModel);
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

            var viewModelWithList = new PageWithListViewModel
            {
                Slide = slide,
                ListItems = TxtListsParser.GetListFormFiles("InboundMarketStatistics")
            };

            var viewModel = new SlideAndSlideWithListsViewModel
            {
                PageWithList = viewModelWithList
            };

            return View(viewModel);
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

            var viewModelWithList = new PageWithListViewModel
            {
                Slide = slide,
                ListItems = TxtListsParser.GetListFormFiles("KeyInsights")
            };

            var viewModel = new SlideAndSlideWithListsViewModel
            {
                PageWithList = viewModelWithList
            };

            return View(viewModel);
        }

    }
}