using System;
using Lab3.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.ViewModels
{
    public class CityFormViewModel
    {
        public City City { get; set; }
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<CityStatus> CityStatuses { get; set; }
    }
}