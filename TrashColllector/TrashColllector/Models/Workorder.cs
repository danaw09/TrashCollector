using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashColllector.Models
{
    public class Workorder
    {
        public int Id { get; set; }
        public DateTime submittedDateTime { get; set; }
        public DateTime scheduledDateTime { get; set; }
        public int TypeId { get; set; }
        public Customer customer { get; set; }
        public DateTime completionDate { get; set; }
    }
}