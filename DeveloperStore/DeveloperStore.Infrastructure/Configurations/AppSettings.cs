using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.API.Configurations
{
    public class AppSettings
    {
        public string ConnectionString { get; set; }
        public string JwtSecret { get; set; }
        public string ApiBaseUrl { get; set; }
    }
}

