using Autofac;
using Autofac.Integration.WebApi;
using HealthCatalyst.PSA.DAL.EntityModel;
using HealthCatalyst.PSA.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace HealthCatalyst.PSA.WebAPI.CompositionRootManager
{
    public class CompositionRoot
    {
        ContainerBuilder builder = new ContainerBuilder();

        public void CompositionRootGenerator() {
            
            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //Register your Autofac Modules
            builder.RegisterModule(new BALRegister());
            builder.RegisterModule(new DALRegister());
            builder.RegisterModule(new RepositoryRegister());
        }

        public void DependencyResolver() {
            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
        }
    }
}