using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrashColllector.Models
{
    public class WeekDay
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string AbbreviationShort { get; set; }

        [Required]
        public string AbbreviationMedium { get; set; }

        [Required]
        public string AbbreviationLong { get; set; }

        [Required]
        public bool AreOperating { get; set; }

       



    }
}