using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashColllector.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string addressLine { get; set; }
        public int postalCodeId{ get; set; }
        public int Postalcode  { get; set; }
    }
}