using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            var slide = new Slide
            {                
                Name = "Meet Us Form",
                Links = new List<Link>
                {
                    new Link()
                    {
                        LinkText = "Back to main",
                        ActionName = "Index",
                        ControllerName = "Home"
                    }
                }
            };
            return View(slide);
        }
    }
}