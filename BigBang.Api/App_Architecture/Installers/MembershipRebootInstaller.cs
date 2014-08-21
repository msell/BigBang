using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using BrockAllen.MembershipReboot;
using BrockAllen.MembershipReboot.Ef;
using BrockAllen.MembershipReboot.WebHost;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace BigBang.Api.App_Architecture.Installers
{
    public class MembershipRebootInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                    Component.For<UserAccountService>(),
                    Component.For<AuthenticationService>().ImplementedBy<SamAuthenticationService>(),
                    Component.For<IUserAccountQuery>().ImplementedBy<DefaultUserAccountRepository>().LifestyleTransient(),
                   Component.For<IUserAccountRepository>().ImplementedBy<DefaultUserAccountRepository>().LifestyleTransient().Named("UserAccountRepo")
                );
        }
    }
}