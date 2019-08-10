using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashColllector.Models
{
    public class Employee
    {
        
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Key]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int? ServicePostalCodeId { get; set; }
        public Postalcode ServicePostalCode { get; set; }
        public string ServicePostalCodeForm { get; internal set; }
        public string UserId { get; internal set; }
    }
}