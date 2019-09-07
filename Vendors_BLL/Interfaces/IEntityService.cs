using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vendors_DAL.Models;

namespace Vendors_BLL.Interfaces
{
    public interface IEntityService<T> where T: BaseModel
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(int id);
    }
}
