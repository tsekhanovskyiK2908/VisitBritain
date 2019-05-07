using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class TourOfCustomer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public ApplicationUser Customer { get; set; } 

        [Required]
        public string CustomerId { get; set; }

        public Tour Tour { get; set; }

        [Required]
        public Guid TourId { get; set; }

        [Required]
        public DateTime SoldDate { get; set; }
    }
}