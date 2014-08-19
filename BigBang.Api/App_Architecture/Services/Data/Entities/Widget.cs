using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Highway.Data;

namespace BigBang.Api.App_Architecture.Services.Data.Entities
{
    public class Widget : IIdentifiable<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}