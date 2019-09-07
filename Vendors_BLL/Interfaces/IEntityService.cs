using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vendors_DAL.Models;

namespace Vendors_BLL.Interfaces
{
    public interface IEntityService<T> where T: BaseModel
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        void Update(T entity);
        Task DeleteAsync(int id);
        Task SaveAsync();
    }
}
