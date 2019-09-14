using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vendors_DAL.Models;

namespace Vendors_BLL.Interfaces
{
    public interface IEntityService<T> where T: BaseModel
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetWhereAsync(Expression<Func<T,bool>> predicate);
        Task<List<T>> GetSubsetWhereAsync(Expression<Func<T,bool>> predicate,int skip, int take);
        int Count();
        int CountWhere(Expression<Func<T, bool>> predicate);
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        void Update(T entity);
        Task DeleteAsync(int id);
        Task SaveAsync();
    }
}
