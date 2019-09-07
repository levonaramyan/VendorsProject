using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendors_BLL.Interfaces;
using Vendors_DAL;
using Vendors_DAL.Models;

namespace Vendors_BLL.Implementation
{
    public class VendorService : BaseService, IVendorService
    {
        public VendorService(VendorsDBContext context) : base(context)
        {
        }

        public async Task CreateVendor(Vendor vendor)
        {
            await _context.Addresses.AddAsync(vendor.Address);
            await _context.Contacts.AddAsync(vendor.Contacts);
            await _context.ContactPersons.AddAsync(vendor.ContactPerson);
            await _context.Vendors.AddAsync(vendor);

            await _context.SaveChangesAsync();
        }

        public void DeleteVendor(int id)
        {
            Vendor vendor = _context.Vendors.Where(vend => vend.Id == id).FirstOrDefault();

            if (vendor != null)
                _context.Vendors.Remove(vendor);

            _context.SaveChangesAsync();
        }

        public Vendor GetVendorById(int id)
        {
            Vendor vendor = _context.Vendors.Where(vend => vend.Id == id).FirstOrDefault();

            return vendor;
        }

        public Vendor GetVendorByName(string name)
        {
            Vendor vendor = _context.Vendors.Where(vend => vend.Name == name).FirstOrDefault();

            return vendor;
        }

        public List<Vendor> GetVendors()
        {
            return _context.Vendors.ToList();
        }

        public void UpdateVendor(Vendor vendor)
        {
            Vendor vendorToUpdate = _context.Vendors.Where(v => v.Id == vendor.Id).FirstOrDefault();

            if (vendorToUpdate != null)
                _context.Vendors.Update(vendor);

            _context.SaveChangesAsync();
        }
    }
}
