using Ebook.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Persistence.Context
{
    public class EbookContext : DbContext
    {
        public EbookContext(DbContextOptions options) : base(options)
        {        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

                //on savechanges
    }
}
