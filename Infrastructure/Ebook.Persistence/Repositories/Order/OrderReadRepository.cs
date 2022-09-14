using Ebook.Application.Repositories;
using Ebook.Domain.Entity;
using Ebook.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(EbookContext context) : base(context)
        {
        }
    }
}
