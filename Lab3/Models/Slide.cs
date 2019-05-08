using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Slide
    {
        public int? Number { get; set; }
        public string Name { get; set; }
        public List<Link> Links { get; set; } = new List<Link>();
    }
}