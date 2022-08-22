using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.Migrations
{
    public partial class SeededCountriesAndHotels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "countryCode", "name" },
                values: new object[,]
                {
                    { 1, "SRB", "Serbia" },
                    { 2, "CRO", "Croatia" },
                    { 3, "GER", "Germany" },
                    { 4, "USA", "United States of America" },
                    { 5, "CNY", "China" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "id", "address", "countryId", "name", "rating" },
                values: new object[,]
                {
                    { 1, "Novi Sad", 1, "Hotel Sajam", 4.0999999999999996 },
                    { 2, "Beograd", 1, "Hotel Moskva", 5.0 },
                    { 3, "Dubrovnik", 2, "Hotel Dubrovnik", 4.2000000000000002 },
                    { 4, "Frankfurt", 3, "Weisehotel", 5.0 },
                    { 5, "Fairbanks", 4, "Bestwestern", 4.0999999999999996 },
                    { 6, "Guilin", 5, "Riverside hotel", 3.7999999999999998 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
