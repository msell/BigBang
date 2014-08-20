// [[Highway.Onramp.MVC.Data]]
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;
using Highway.Data;
using Highway.Data.Factories;
using Highway.Data.Repositories;
using BigBang.Api.App_Architecture.Services.Data;

namespace BigBang.Api.App_Architecture.Installers
{
    public class HighwayDataInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IDomainRepositoryFactory>().ImplementedBy<DomainRepositoryFactory>(),
                // TODO: fix hard coded connstring
                Component.For<IDataContext>().ImplementedBy<DataContext>()               
                .DependsOn(Dependency.OnConfigValue("connectionString","Server=(localdb)\v11.0;Database=BigBangDb;Integrated Security=true;")),
                //This is Highway.Data's Repository
                Component.For<IRepository>().ImplementedBy<Repository>()
                );
        }
    }
}
