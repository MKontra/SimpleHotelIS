using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SimpleHotelIS.Repositories;
using System.Data.Entity;
using SimpleHotelIS.Authorization;
using SimpleHotelIS.BusinessPipelines;
using SimpleHotelIS.BusinessPipelines.Interfaces;
using SimpleHotelIS.Utils;
using SimpleHotelIS.Validations;
using SimpleHotelIS.BusinessPipelines.Facades;
using Castle.Windsor;
using Castle.Windsor.Installer;
using System.Web.Http.Dispatcher;
using Castle.MicroKernel.Registration;
using Castle.Facilities.TypedFactory;
using SimpleHotelIS.BusinessPipelines.Interfaces.TaskBased;

namespace SimpleHotelIS
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
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


        protected void Application_Start() {

            AreaRegistration.RegisterAllAreas();

            BootStrapIoCContainer(new WindsorContainer());
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            BundleTable.Bundles.EnableDefaultBundles();
            //BundleTable.Bundles.RegisterTemplateBundles();
            //var appset = new DictionaryAdapterFactory().GetAdapter<Zakaznik>(ConfigurationManager.AppSettings);

        }

        private void BootStrapIoCContainer(WindsorContainer container)
        {
            var controllerFactory = new CastleWindsorControllerFactory(container.Kernel);     // Create a new instance
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);          // Use my factory instead of default
            GlobalConfiguration.Configuration.Services.Replace(
                typeof(IHttpControllerActivator),
                new CastleWindsorHttpControllerActivator(container));

            container.AddFacility<TypedFactoryFacility>();
            RegisterServices(container);

            container.Install(
                FromAssembly.This()
            ); 
        }

        private void RegisterServices(WindsorContainer container)
        {
            container.Register( Component.For<IModelStore>().ImplementedBy<HotelEntitesModelStore>().LifestylePerWebRequest() );
            container.Register(
                Component.For<IInputValidationProvider>().ImplementedBy<DbContextInputValidationProvider>().DynamicParameters(
                    (kernel, context) => 
                    {
                        IModelStore ims = kernel.Resolve<IModelStore>();
                        DbContext dbc = ims.unwrap<DbContext>();
                        context["dbc"] = dbc;
                        return (r) => { r.ReleaseComponent(ims); };
                    }).LifestyleTransient().Named("inputValidator"),
                Component.For<IBusinessValidationProvider>().ImplementedBy<ModelStoreBusinessValidationProvider>().LifestyleTransient().Named("businessValidator") ,
                Component.For<IAuthorizationProvider>().ImplementedBy<EmptyAuthorizationProvider>().LifestyleTransient()
                );
            container.Register(
                Component.For(typeof(ICreateService<,>)).ImplementedBy(typeof(DefaultEntityCreate<,>)).LifestyleTransient(),
                Component.For(typeof(IGetByIdService<,>)).ImplementedBy(typeof(DefaultGetById<,>)).LifestyleTransient()
                );
            container.Register(
                Component.For(typeof(ICrudServiceProvider<,>)).AsFactory()
                );

            container.Register(
                Component.For(typeof(IGetByIdServiceTask<,>)).ImplementedBy(typeof(DefaultGetByIdServiceTask<,>)).LifestyleTransient(),
                Component.For(typeof(IAsQueryableServiceTask<,>)).ImplementedBy(typeof(DefaultAsQueryableServiceTask<,>)).LifestyleTransient()
                );
            
            container.Register(
                Component.For(typeof(ITaskBasedCrudServiceProvider<,>)).AsFactory()
    );
        }

        /**
        protected override Ninject.IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            kernel.Bind<IModelStore>().To<HotelEntitesModelStore>().InRequestScope();
            kernel.Bind<IInputValidationProvider>().To<DbContextInputValidationProvider>().When( request=>request.Target.Name.StartsWith("input")).WithConstructorArgument("dbc", ctx => ctx.Kernel.Get<IModelStore>().unwrap<DbContext>());
            kernel.Bind<IInputValidationProvider>().To<ModelStoreBusinessValidationProvider>().When( request => request.Target.Name.StartsWith("business"));
            kernel.Bind<IAuthorizationProvider>().To<EmptyAuthorizationProvider>();

            kernel.Bind(typeof(ICreateService<,>)).To(typeof(DefaultEntityCreate<,>));
            kernel.Bind(typeof(IGetByIdService<,>)).To(typeof(DefaultGetById<,>));

            kernel.Bind(typeof(ICrudServiceProvider<,>)).ToFactory();

            GlobalConfiguration.Configuration.DependencyResolver;

            return kernel;
        }
         **/

    }
}