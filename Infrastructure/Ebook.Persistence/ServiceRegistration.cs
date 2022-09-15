using Ebook.Application.Repositories;
using Ebook.Persistence.ConfigurationJson;
using Ebook.Persistence.Context;
using Ebook.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Persistence
{
   public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            ///  services.AddSingleton<IProductServices, ProductServices>();
            ///  services.AddDbContext<EtradeAPIContext>(option => option.UseNpgsql(""));
            ///  //1
            //services.AddDbContext<EbookContext>(options => options.UseSqlServer(Configuration.ConnectionString),ServiceLifetime.Singleton);

            //services.AddSingleton<ICustomerReadRepository,CustomerReadRepository>();
            //services.AddSingleton<ICustomerWriteRepository,CustomerWriteRepository>();
            //services.AddSingleton<IOrderReadRepository,OrderReadRepository> ();
            //services.AddSingleton<IOrderWriteRepository,OrderWriteRepository>();
            //services.AddSingleton<IProductReadRepository,ProductReadRepository>();
            //services.AddSingleton<IProductWriteRepository,ProductWriteRepository>();
            /// //2
            services.AddDbContext<EbookContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
