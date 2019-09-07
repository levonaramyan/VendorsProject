using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vendors_DAL.Models;

namespace Vendors_BLL.Interfaces
{
    public interface ICityService : IEntityService<City>
    {
        Task<List<City>> GetCitiesByCountryId(int id);
    }
}
