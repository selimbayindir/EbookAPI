using Ebook.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Application.Repositories
{
    public interface ICustomerWriteRepository :IWriteRepository<Customer>
    {
    }
}
