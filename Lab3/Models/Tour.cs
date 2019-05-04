using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Tour
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(55)]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Departure From")]
        public string DepartureCity { get; set; }

        [Required]
        [Display(Name = "Departure At")]
        public DateTime DepartureDate { get; set; }

        [Required]
        [Display(Name = "Arrival To")]
        public string ArrivalCity { get; set; }

        [Required]
        [Display(Name = "Arrival At")]
        public DateTime ArrivalDate { get; set; }

        [Required]
        [Display(Name ="Price per person")]
        public float Price { get; set; }

        [Required]
        [Display(Name = "Places avaliable")]
        public int PlaceNumber { get; set; }

        //public Tour()
        //{
        //    Id = Guid.Empty;
        //}

    }
}