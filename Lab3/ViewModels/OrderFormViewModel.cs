using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab3.Models;

namespace Lab3.ViewModels
{
    public class OrderFormViewModel
    {
        public TourOfCustomer TourOfCustomer { get; set; }
        public IEnumerable<ApplicationUser> ApplicationUsers { get; set; }
        public IEnumerable<Tour> Tours { get; set; }
    }
}