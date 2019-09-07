using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Vendors_BLL.Interfaces;
using Vendors_DAL;

namespace Vendors_BLL.Implementation
{
    public class BaseService : IBaseService, IDisposable
    {
        protected VendorsDBContext _context;
        public BaseService(VendorsDBContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
