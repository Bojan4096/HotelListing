using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    id = 1,
                    name = "Hotel Sajam",
                    address = "Novi Sad",
                    countryId = 1,
                    rating = 4.1,
                },
                new Hotel
                {
                    id = 2,
                    name = "Hotel Moskva",
                    address = "Beograd",
                    countryId = 1,
                    rating = 5,
                },
                new Hotel
                {
                    id = 3,
                    name = "Hotel Dubrovnik",
                    address = "Dubrovnik",
                    countryId = 2,
                    rating = 4.2,
                },
                new Hotel
                {
                    id = 4,
                    name = "Weisehotel",
                    address = "Frankfurt",
                    countryId = 3,
                    rating = 5,
                },
                new Hotel
                {
                    id = 5,
                    name = "Bestwestern",
                    address = "Fairbanks",
                    countryId = 4,
                    rating = 4.1,
                },
                new Hotel
                {
                    id = 6,
                    name = "Riverside hotel",
                    address = "Guilin",
                    countryId = 5,
                    rating = 3.8,
                }
            );
        }
    }
}
