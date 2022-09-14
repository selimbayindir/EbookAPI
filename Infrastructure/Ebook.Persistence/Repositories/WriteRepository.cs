using Ebook.Application.Repositories;
using Ebook.Domain.Entity.Common;
using Ebook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        readonly private EbookContext _context;

        public WriteRepository(EbookContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>(); //İlgili Contextin db seti elde edilir.

        public async Task<bool> AddAsync(T model)
        {
            //_context.AddAsync(model);
            //_context.SaveChanges();
          EntityEntry<T> entityEntry= await Table.AddAsync(model);
            return entityEntry.State==EntityState.Added; //true false
        }
        public async Task<bool> AddRangeAsync(List<T> model)
        {
            await Table.AddRangeAsync(model);
            return true;
        }


        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted; //true false
        }
        public bool Remove(string id)
        {
         T model=Table.FirstOrDefault(p => p.Id == Guid.Parse(id));/// Önce Datayı bul
          return  Remove(model);

        }
        public bool RemoveRange(List<T> model)
        {
            Table.RemoveRange(model);
            return true;
        }
        public bool Update(T model)
        {
            EntityEntry<T> entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;

        }
        public async Task<int> SaveAsync()
        {
          return await _context.SaveChangesAsync();

        }

     
    }

}

