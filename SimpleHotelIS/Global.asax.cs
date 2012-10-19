using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject.Web.Common;
using Ninject;
using SimpleHotelIS.Repositories;
using System.Data.Entity;
using SimpleHotelIS.Models;
using SimpleHotelIS.Authorization;
using SimpleHotelIS.BussinesPipelines;
using SimpleHotelIS.BussinesPipelines.Interfaces;
using SimpleHotelIS.Utils;

namespace SimpleHotelIS
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : NinjectHttpApplication
    {



        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
                name: "HotelApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { controller = "Help", id = System.Web.Http.RouteParameter.Optional }
            );

            routes.MapRoute(
                name: "Hotel",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );



        }

        protected override void OnApplicationStarted()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            BundleTable.Bundles.RegisterTemplateBundles();
        }

        protected override Ninject.IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            kernel.Bind<IModelStore>().To<HotelEntitesModelStore>().InRequestScope();
            kernel.Bind<IValidationProvider>().To<DbContextValidationProvider>().WithConstructorArgument("dbc", ctx => ctx.Kernel.Get<IModelStore>().unwrap<DbContext>());
            kernel.Bind<IAuthorizationProvider>().To<EmptyAuthorizationProvider>();
            kernel.Bind<ICrudServiceProvider>().To<DefaultCrudServiceProvider>();

            GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);

            return kernel;
        }

    }
}