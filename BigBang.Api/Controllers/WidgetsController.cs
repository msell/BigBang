using System.Collections.Generic;
using System.Web.Http;
using BigBang.Api.App_Architecture.Services.Data.Entities;
using BigBang.Api.App_Architecture.Services.Data.Queries;
using Highway.Data;

namespace BigBang.Api.Controllers
{
    public class WidgetsController : ApiController
    {
        readonly IRepository _repository;

        public WidgetsController(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Widget> Get()
        {
            return _repository.Find(new AllWidgets());
        }
    }
}
