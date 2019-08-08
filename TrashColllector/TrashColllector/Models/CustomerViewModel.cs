using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using TrashColllector.Models;

namespace TrashCollector.Models
{

    public class CustomerViewModel
    {
       
        public string UserId { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string NameLast { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string NameFirst { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string AddressForm { get; set; }

        [Required]
        [Display(Name = "City")]
        public string CityName{ get; set; }

        [Required]
        [Display(Name = "State")]
        public int StateIdForm { get; set; }

        public IEnumerable<State> StateList { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        [Required]
        [Display(Name = "Weekly Service Day")]
        public int WeeklyPickupDayId { get; set; }

        public IEnumerable<WeekDay> DaysOfOperation { get; set; }

        
    }
}