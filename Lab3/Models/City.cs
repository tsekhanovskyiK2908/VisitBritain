using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public CityStatus CityStatus { get; set; }

        [Required]
        public Guid CityStatusId { get; set; }

        public Country Country { get; set; }

        [Required]
        public Guid CountryId { get; set; }

        [Required]
        public string Description { get; set; }

    }
}