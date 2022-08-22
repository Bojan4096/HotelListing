﻿// <auto-generated />
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelListing.API.Migrations
{
    [DbContext(typeof(HotelListingDbContext))]
    [Migration("20220822094824_SeededCountriesAndHotels")]
    partial class SeededCountriesAndHotels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HotelListing.API.Data.Country", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("countryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            id = 1,
                            countryCode = "SRB",
                            name = "Serbia"
                        },
                        new
                        {
                            id = 2,
                            countryCode = "CRO",
                            name = "Croatia"
                        },
                        new
                        {
                            id = 3,
                            countryCode = "GER",
                            name = "Germany"
                        },
                        new
                        {
                            id = 4,
                            countryCode = "USA",
                            name = "United States of America"
                        },
                        new
                        {
                            id = 5,
                            countryCode = "CNY",
                            name = "China"
                        });
                });

            modelBuilder.Entity("HotelListing.API.Data.Hotel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("countryId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("rating")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("countryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            id = 1,
                            address = "Novi Sad",
                            countryId = 1,
                            name = "Hotel Sajam",
                            rating = 4.0999999999999996
                        },
                        new
                        {
                            id = 2,
                            address = "Beograd",
                            countryId = 1,
                            name = "Hotel Moskva",
                            rating = 5.0
                        },
                        new
                        {
                            id = 3,
                            address = "Dubrovnik",
                            countryId = 2,
                            name = "Hotel Dubrovnik",
                            rating = 4.2000000000000002
                        },
                        new
                        {
                            id = 4,
                            address = "Frankfurt",
                            countryId = 3,
                            name = "Weisehotel",
                            rating = 5.0
                        },
                        new
                        {
                            id = 5,
                            address = "Fairbanks",
                            countryId = 4,
                            name = "Bestwestern",
                            rating = 4.0999999999999996
                        },
                        new
                        {
                            id = 6,
                            address = "Guilin",
                            countryId = 5,
                            name = "Riverside hotel",
                            rating = 3.7999999999999998
                        });
                });

            modelBuilder.Entity("HotelListing.API.Data.Hotel", b =>
                {
                    b.HasOne("HotelListing.API.Data.Country", "country")
                        .WithMany("hotels")
                        .HasForeignKey("countryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");
                });

            modelBuilder.Entity("HotelListing.API.Data.Country", b =>
                {
                    b.Navigation("hotels");
                });
#pragma warning restore 612, 618
        }
    }
}
