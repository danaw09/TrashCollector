using System.ComponentModel.DataAnnotations;

namespace TrashColllector.Models
{
    public class Customer
    {
        [Required]
        [Key]
        public string UserId { get; set; }
        public string phone { get; set; }
        public string LastName { get; set; }
        public string address { get; set; }
        public string addressId { get; set; }
        public string WeeklyPickUpDay { get; set; }
        public string postalCode { get; set; }


    }
   
}