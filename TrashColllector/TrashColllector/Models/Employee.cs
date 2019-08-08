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
        public string UserId { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int? ServicePostalCodeId { get; set; }
        public Postalcode ServicePostalCode { get; set; }


        public static Employee GetEmployeeById(ApplicationDbContext _context, string userId)
        {
            return _context.employees.SingleOrDefault(e => e.UserId== userId);
        }
    }
}