using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using BigBang.Api.App_Architecture.Services.Data.Entities;

namespace BigBang.Api.App_Architecture.Services.Data.Mappings
{
    public class WidgetConfiguration : EntityTypeConfiguration<Widget>
    {
        public WidgetConfiguration()
        {
            ToTable("Widgets");
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();
            Property(x => x.Name).IsRequired().HasMaxLength(150);
        }
    }
}