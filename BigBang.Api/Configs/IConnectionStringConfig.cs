// [[Highway.Onramp.MVC]]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Castle.Components.DictionaryAdapter;

namespace BigBang.Api.Configs
{
    [KeyPrefix("EntityFramework.")]
    public interface IConnectionStringConfig
    {
        string ConnectionString { get; set; }
    }
}