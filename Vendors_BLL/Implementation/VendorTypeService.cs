using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vendors_BLL.Interfaces;
using Vendors_DAL;
using Vendors_DAL.Models;

namespace Vendors_BLL.Implementation
{
    public class VendorTypeService : BaseService, IVendorTypeService
    {
        public VendorTypeService(VendorsDBContext context) : base(context)
        {
        }

        public Task Create(VendorType vendorType)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<VendorType> GetAll()
        {
            throw new NotImplementedException();
        }

        public VendorType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public VendorType GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(VendorType vendorType)
        {
            throw new NotImplementedException();
        }
    }
}
