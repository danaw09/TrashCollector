using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashColllector.Models
{
    public class Postalcode
    {
        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; }
        public string Code { get; set; }

        public static Postalcode AddPostalCode(ApplicationDbContext _context, Postalcode postalCode)
        {
            var newPostalCode = new Postalcode()
            {
                Code = postalCode.Code,
                CityId = City.GetCityId(_context, postalCode.City)
            };

            if (newPostalCode.CityId == 0)
            {
                newPostalCode.City = City.AddCity(_context, postalCode.City);
                newPostalCode.CityId = newPostalCode.City.Id;
            }

            _context.postalcode.Add(newPostalCode);
            _context.SaveChanges();

            return newPostalCode;
        }
        public static int GetPostalCodeId(ApplicationDbContext _context, Postalcode postalCode)
        {
            var result = _context.postalcode
               
                .Where(p => p.Code == postalCode.Code
                && p.City.Name == postalCode.City.Name
                && p.City.State.Name == postalCode.City.State.Name).SingleOrDefault();

            return result == null ? 0 : result.CityId;
        }
    }

       
    
}