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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            
        //}
    }
}
