using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class CityStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public static readonly Guid Capital = new Guid("9d4554a9-b76e-e911-af30-b0359f002e18");
        public static readonly Guid CultureCapital = new Guid("9e4554a9-b76e-e911-af30-b0359f002e18");
        public static readonly Guid MillionareCity = new Guid("9f4554a9-b76e-e911-af30-b0359f002e18");
        public static readonly Guid RegionalCentre = new Guid("a04554a9-b76e-e911-af30-b0359f002e18");
        public static readonly Guid IndustrialCentre = new Guid("a14554a9-b76e-e911-af30-b0359f002e18");
    }
}