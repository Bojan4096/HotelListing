using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HotelListing.API.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    id = 1,
                    name = "Serbia",
                    countryCode = "SRB"
                },
                new Country
                {
                    id = 2,
                    name = "Croatia",
                    countryCode = "CRO"
                },
                new Country
                {
                    id = 3,
                    name = "Germany",
                    countryCode = "GER"
                },
                new Country
                {
                    id = 4,
                    name = "United States of America",
                    countryCode = "USA"
                },
                new Country
                {
                    id = 5,
                    name = "China",
                    countryCode = "CNY"
                }
            );
        }
    }
}
