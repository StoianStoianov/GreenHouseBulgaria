using GreenHouseBulgaria.Data;
using GreenHouseBulgaria.Data.Repositories;
using GreenHouseBulgaria.Services.Contracts;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(GreenHouseBulgaria.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(GreenHouseBulgaria.Web.App_Start.NinjectWebCommon), "Stop")]

namespace GreenHouseBulgaria.Web.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Services;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IGreenHouseBulgariaDbContext>().To<GreenHouseBulgariaDbContext>();
            kernel.Bind<IServiceService>().To<ServiceService>();
            kernel.Bind<ISubscriptionService>().To<SubscriptionService>();
            kernel.Bind<IServicePriceService>().To<ServicePriceService>();
            kernel.Bind(typeof(IRepository<>)).To(typeof(EFRepository<>));
        }        
    }
}
