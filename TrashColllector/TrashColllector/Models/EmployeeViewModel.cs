using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TrashColllector.Models;

namespace TrashCollector.Models
{
    public class EmployeeViewModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName{ get; set; }

        public int? ServicePostalCodeId { get; set; }
        public Postalcode ServicePostalCode { get; set; }
       
        [Display(Name = "Postal Code")]
        public string ServicePostalCodeForm { get; set; }
    }
}