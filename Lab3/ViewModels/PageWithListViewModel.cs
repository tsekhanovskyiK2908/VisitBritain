using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab3.Models;

namespace Lab3.ViewModels
{
    public class PageWithListViewModel
    {
        public Slide Slide { get; set; }
        public IEnumerable<string> ListItems { get; set; }
    }
}