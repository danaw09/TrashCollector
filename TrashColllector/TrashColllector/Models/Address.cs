using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashColllector.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressLine { get; set; }

        [ForeignKey("PostalCode")]
        public int PostalCodeId { get; set; }
        public Postalcode PostalCode { get; set; }

        public static Address AddAddress(ApplicationDbContext _context, Address address)
        {
            var newAddress = new Address()
            {
                AddressLine = address.AddressLine,
                PostalCodeId = Postalcode.GetPostalCodeId(_context, address.PostalCode)
            };

            if (newAddress.PostalCodeId == 0)
            {
                newAddress.PostalCode = Postalcode.AddPostalCode(_context, address.PostalCode);
                newAddress.PostalCodeId = newAddress.PostalCode.CityId;
            }

            _context.Addresses.Add(newAddress);
            _context.SaveChanges();

            return newAddress;

        }

        public static int GetAddressId(ApplicationDbContext _context, Address address)
        {
            var result = _context.Addresses
              
                .Where(a => a.AddressLine == address.AddressLine
                && a.PostalCode.Code == address.PostalCode.Code
                && a.PostalCode.City.Name == address.PostalCode.City.Name
                && a.PostalCode.City.State.Name == address.PostalCode.City.State.Name)
                .FirstOrDefault();


            return result == null ? 0 : result.Id;
        }
    }
}
}