using Ebook.Domain.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Domain.Entity
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }
        public string Address { get; set; }

        public ICollection<Product> products { get; set; }
        public Customer Customer { get; set; }
    }
}
