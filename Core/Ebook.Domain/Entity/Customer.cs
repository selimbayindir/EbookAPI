using Ebook.Domain.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Domain.Entity
{
    public class Customer : BaseEntity
    {
        public string CustomerName { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
