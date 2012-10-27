using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;
using System.Web.Mvc;
using SimpleHotelIS.Controllers;

namespace SimpleHotelIS.Utils
{
    public class CastleWindsorControllerInstaller : IWindsorInstaller
    {
        /// <summary>
        /// Installs the controllers
        /// </summary>
        /// <param name="container"></param>
        /// <param name="store"></param>
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(FindControllers().Configure(c => c.LifestyleTransient()));
        }

        /// <summary>
        /// Find controllers within this assembly in the same namespace as HomeController
        /// </summary>
        /// <returns></returns>
        private BasedOnDescriptor FindControllers()
        {
            return AllTypes.FromThisAssembly()
                .BasedOn<IController>();
                //.If(Component.IsInSameNamespaceAs<HomeController>())
                //.If(t => t.Name.EndsWith("Controller"));

        }

    }
}