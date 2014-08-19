// [[Highway.Onramp.MVC.Data]]
using Highway.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace BigBang.Api.App_Architecture.Services.Data
{
    public class HighwayContextConfiguration : IContextConfiguration
    {
        public void ConfigureContext(DbContext context)
        {
            context.Configuration.LazyLoadingEnabled = false;
            context.Configuration.ProxyCreationEnabled = false;
        }
    }
}
