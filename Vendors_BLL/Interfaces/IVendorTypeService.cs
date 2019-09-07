using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vendors_DAL.Models;

namespace Vendors_BLL.Interfaces
{
    public interface IVendorTypeService
    {
        List<VendorType> GetAll();
        VendorType GetById(int id);
        VendorType GetByName(string name);
        Task Create(VendorType vendorType);
        void Update(VendorType vendorType);
        void Delete(int id);
    }
}
