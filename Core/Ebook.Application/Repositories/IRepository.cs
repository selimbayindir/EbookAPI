using Ebook.Domain.Entity.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity //çapını kısalt
    {
        DbSet<T> Table { get; } //constrait mantığı
    }
}
