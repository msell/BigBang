// [[Highway.Onramp.MVC.Data]]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigBang.Api.Entities.Mappings
{
    public class ExampleEntityMapping : BaseMapping<ExampleEntity>
    {
        public ExampleEntityMapping()
        {
            this.Property(e => e.Name).IsOptional();
        }
    }
}