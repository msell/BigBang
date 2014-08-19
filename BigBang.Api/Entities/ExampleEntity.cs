// [[Highway.Onramp.MVC.Data]]
using Highway.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BigBang.Api.Entities
{
    public class ExampleEntity : BaseEntity
    {
        // Id is a Guid and inherited from BaseEntity
        public string Name { get; set; }
    }
}
