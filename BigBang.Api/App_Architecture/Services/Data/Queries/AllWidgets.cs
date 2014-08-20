using BigBang.Api.App_Architecture.Services.Data.Entities;
using Highway.Data;

namespace BigBang.Api.App_Architecture.Services.Data.Queries
{
    public class AllWidgets : Query<Widget>
    {
        public AllWidgets()
        {
            ContextQuery = context => context.AsQueryable<Widget>();
        }
    }
}