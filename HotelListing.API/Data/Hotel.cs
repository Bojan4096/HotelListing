using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Data
{
    public class Hotel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public double rating { get; set; }
        [ForeignKey(nameof(countryId))] 
        public int countryId { get; set; }
        public Country country { get; set; }

    }
}
