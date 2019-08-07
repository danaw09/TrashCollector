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
        public string NameLast { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string NameFirst { get; set; }

        public int? ServicePostalCodeId { get; set; }
        public Postalcode ServicePostalCode { get; set; }
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Zip code must be 5 digits")]
        [RegularExpression("^[0-9]{5}$", ErrorMessage = "Zip code can only contain numerical digits.")]
        [Display(Name = "Postal Code")]
        public string ServicePostalCodeForm { get; set; }
    }
}