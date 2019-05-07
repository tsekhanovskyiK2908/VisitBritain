﻿using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class FormController : Controller
    {
        private LinksHolder _linksHolder;

        public FormController()
        {
            _linksHolder = new LinksHolder();
        }
        // GET: Form
        public ActionResult Index()
        {

            var slide = new Slide
            {                
                Name = "Meet Us Form",
                Links = new List<Link>
                {
                   _linksHolder.Main
                }
            };
            return View(slide);
        }
    }
}