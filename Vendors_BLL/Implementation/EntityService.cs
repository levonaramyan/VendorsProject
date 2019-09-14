using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vendors_BLL.Interfaces;
using Vendors_DAL;
using Vendors_DAL.Models;

namespace Vendors_BLL.Implementation
{
    public class EntityService<T> : BaseService, IEntityService<T> where T : BaseModel
    {
        private DbSet<T> table = null;
        public EntityService(VendorsDBContext context) : base(context)
        {
            table = _context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await table.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            T existing = await table.FindAsync(id);
            table.Remove(existing);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await table.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await table.FindAsync(id);
        }

        public void Update(T entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetWhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await table.Where(predicate).ToListAsync();
        }

        public async Task<List<T>> GetSubsetWhereAsync(Expression<Func<T, bool>> predicate, int skip, int take)
        {
            return await table.Where(predicate).Skip(skip).Take(take).ToListAsync();
        }

        public int Count()
        {
            return table.Count();
        }

        public int CountWhere(Expression<Func<T, bool>> predicate)
        {
            return table.Where(predicate).Count();
        }
    }
}
