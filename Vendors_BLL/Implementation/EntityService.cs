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
    public class EntityService<T> : BaseService, IEntityService<T> where T : BaseModel
    {
        private DbSet<T> table = null;
        public EntityService(VendorsDBContext context) : base(context)
        {
            table = _context.Set<T>();
        }

        public async Task Create(T entity)
        {
            await table.AddAsync(entity);

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            T entityToDelete = await table.Where(ent => ent.Id == id).FirstOrDefaultAsync();

            if (entityToDelete != null)
            {
                table.Remove(entityToDelete);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll()
        {
            List<T> entities = await table.ToListAsync();

            return entities;
        }

        public async Task<T> GetById(int id)
        {
            T entity = await table.Where(ent => ent.Id == id).FirstOrDefaultAsync();

            return entity;
        }

        public async Task Update(T entity)
        {
            T entityToUpdate = await table.Where(ent => ent.Id == entity.Id).FirstOrDefaultAsync();

            if (entityToUpdate != null)
            {
                table.Update(entity);
            }

            await _context.SaveChangesAsync();
        }
    }
}
