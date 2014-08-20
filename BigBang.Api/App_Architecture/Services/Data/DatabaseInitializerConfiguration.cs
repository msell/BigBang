using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BigBang.Api.Configs;

namespace BigBang.Api.App_Architecture.Services.Data
{
    public class DatabaseInitializerConfiguration : IDatabaseInitializerConfig
    {
        public DatabaseInitializerConfiguration()
        {
            Initializer = InitializerTypes.DropCreateDatabaseAlways;
        }
        public InitializerTypes Initializer { get; set; }
    }
}