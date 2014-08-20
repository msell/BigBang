// [[Highway.Onramp.MVC.Data]]

using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;
using Highway.Data.Factories;

namespace BigBang.Api.App_Architecture.Installers
{
    public class HighwayDataInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IDomainRepositoryFactory>().ImplementedBy<DomainRepositoryFactory>()                
                );
        }
    }
}
