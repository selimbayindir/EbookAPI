using Ebook.Application.Repositories;
using Ebook.Domain.Entity.Common;
using Ebook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

        public IQueryable<T> GetAll(bool tracking = true)
        {
            //=>Table();
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            //return await Table.FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));
            //=> await Table.FindAsync(Guid.Parse(id));

            var query = Table.AsQueryable();
            if (!tracking)
                query = Table.AsNoTracking();

            return await query.FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));
                    }
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            //=> await Table.FirstOrDefaultAsync(method);
            var query = Table.AsQueryable();
            if (!tracking)
                query = Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        }

        /// =>await Table.FirstOrDefaultAsync(method);

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }
    }
}
