using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Application.Repositories
{
    public interface IReadRepository<T>  :IRepository<T> where T : class 
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        Task GetSingleAsync(Expression<Func<T, bool>> method);
        Task GetByIdAsync(string id);
    }
}
