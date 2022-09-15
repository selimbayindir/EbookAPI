using Ebook.Application.Repositories;
using Ebook.Domain.Entity.Common;
using Ebook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity //class
    {
        private readonly EbookContext _context;

        public ReadRepository(EbookContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll() => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        {
          return  await Table.FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));

        }
                    /// => Table.Where(method);


        public async Task GetSingleAsync(Expression<Func<T, bool>> method)
        {
            await Table.FirstOrDefaultAsync(method);
        }
                    /// =>await Table.FirstOrDefaultAsync(method);
        
        public async Task GetByIdAsync(string id)
        {
            await Table.FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));
        }
    }
}
