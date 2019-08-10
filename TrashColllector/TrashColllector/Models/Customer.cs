using System.ComponentModel.DataAnnotations;

namespace TrashColllector.Models
{
    public class Customer
    {
        [Required]
        [Key]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "user id")]
        public string UserId { get; set; }

        [Display(Name = "Phone")]
        public string phone { get; set; }
        
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "street address")]
        public string Streetaddress { get; set; }

        [Display(Name = "address Id")]
        public string AddressId { get; set; }

        [Display(Name = "weekly pick up day")]
        public string WeeklyPickUpDay { get; set; }

        [Display(Name = "Postal Code")]
        public string postalCode { get; set; }

        [Display(Name = "Bill")]
        public string bill { get; set; }

        [Display(Name = "CIty")]
        public string city { get; set; }

        [Display(Name = "State")]
        public string state { get; set; }

        [Display(Name = "Address")]
        public object Address { get; internal set; }

        [Display(Name = "Weekly Pick Up Day Id")]
        public string WeeklyPickUpDayId { get; set; }

    }
   
}