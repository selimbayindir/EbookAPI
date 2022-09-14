using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.Persistence.ConfigurationJson
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/EbookAPI.WebAPI"));
                configurationManager.AddJsonFile("appsettings.json");
                   
                return configurationManager.GetConnectionString("SqlServer");
            }

        }
    }
}
