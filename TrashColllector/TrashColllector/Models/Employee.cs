using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashColllector.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
    }
}