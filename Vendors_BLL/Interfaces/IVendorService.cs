using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vendors_DAL.Models;

namespace Vendors_BLL.Interfaces
{
    public interface IVendorService
    {
        List<Vendor> GetVendors();
        Vendor GetVendorById(int id);
        Vendor GetVendorByName(string name);
        Task CreateVendor(Vendor vendor);
        void UpdateVendor(Vendor vendor);
        void DeleteVendor(int id);
    }
}
