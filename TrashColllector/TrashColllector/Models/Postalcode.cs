using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashColllector.Models
{
    public class Postalcode
    {
        public int  Id{ get; set; }
        public int cityId { get; set; }
        public City city{ get; set; }
    }
}