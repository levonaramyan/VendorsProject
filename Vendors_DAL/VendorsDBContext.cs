using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Vendors_DAL.Models;

namespace Vendors_DAL
{
    public class VendorsDBContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactPerson> ContactPersons { get; set; }
        public DbSet<VendorType> VendorTypes { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        public VendorsDBContext(DbContextOptions<VendorsDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VendorType>().HasData(
            new VendorType[]
            {
                new VendorType { Id=1, Name="Restaurant"},
                new VendorType { Id=2, Name="Hotel"},
                new VendorType { Id=3, Name="Attraction"},
                new VendorType { Id=4, Name="Bus Company"}
            });

            modelBuilder.Entity<Country>().HasData(
            new Country[]
            {
                new Country { Id=1, Name="Armenia"},
                new Country { Id=2, Name="USA"},
                new Country { Id=3, Name="Russia"},
                new Country { Id=4, Name="Canada"}
            });

            modelBuilder.Entity<City>().HasData(
            new City[]
            {
                new City { Id=1, Name="Yerevan", CountryId = 1},
                new City { Id=2, Name="Gyumri", CountryId = 1},
                new City { Id=3, Name="Vanadzor", CountryId = 1},
                new City { Id=4, Name="Artashat", CountryId = 1},
                new City { Id=5, Name="New York", CountryId = 2},
                new City { Id=6, Name="Chicago", CountryId = 2},
                new City { Id=7, Name="Washington DC", CountryId = 2},
                new City { Id=8, Name="Dallas", CountryId = 2},
                new City { Id=9, Name="Moscow", CountryId = 3},
                new City { Id=10, Name="St. Peterbourgh", CountryId = 3},
                new City { Id=11, Name="Krasnodar", CountryId = 3},
                new City { Id=12, Name="Vladivastok", CountryId = 3},
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
