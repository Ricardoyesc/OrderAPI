using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Type { get; set; }
        public string PlaceId { get; set; }
        public string StreetAddressLineOne { get; set; }
        public string StreetAddressLineTwo { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int UnitNumber
        {
            get; set;
        }

        public string BusinessName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public string LocationTypeValue { get; set; }
        public string ClientProvidedStreetAddressLineOne { get; set; }
    }
}