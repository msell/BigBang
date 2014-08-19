// [[Highway.Onramp.MVC]]
using System;
using System.Linq;
using System.Web.Mvc;
using Castle.Windsor;
using System.Collections.Generic;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using BigBang.Api.App_Architecture.Services;
using System.Web.Http.Controllers;

namespace BigBang.Api.App_Architecture.Installers
{
    public class DefaultConventionInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes.FromThisAssembly().Pick()
                    .WithServiceDefaultInterfaces()
                    .Unless(type => typeof(IController).IsAssignableFrom(type) || typeof(IHttpController).IsAssignableFrom(type))
                    .LifestylePerWebRequest()
                );
        }
    }
}
