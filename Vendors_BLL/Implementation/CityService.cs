using Microsoft.EntityFrameworkCore;
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
    public class CityService : EntityService<City>, ICityService
    {
        public CityService(VendorsDBContext context) : base(context)
        {
        }

        public async Task<List<City>> GetCitiesByCountryId(int id)
        {
            return await _context.Cities.Where(x => x.CountryId == id).ToListAsync();
        }
    }
}
