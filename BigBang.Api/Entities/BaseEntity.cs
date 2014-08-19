// [[Highway.Onramp.MVC.Data]]
using Highway.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BigBang.Api.Entities
{
    public abstract class BaseEntity : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
    }
}
