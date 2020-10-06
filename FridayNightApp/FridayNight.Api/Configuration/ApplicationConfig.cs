using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridayNightApp.Configuration
{
    internal sealed class ApplicationConfig
    {
        public Databases Databases { get; set; }
    }

    internal sealed class Databases
    {
        public PostgreSQL PostgreSQL { get; set; }
    }

    internal sealed class PostgreSQL
    {
        public string ConnectionString { get; set; }
    }
}
