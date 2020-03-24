using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using HealthCatalyst.PSA.WebAPI.CompositionRootManager;

namespace HealthCatalyst.PSA.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ConfigureCompositionRoot();   
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SupportedMediaTypes
            .Add(new MediaTypeHeaderValue("text/html")); ;
        }

        private void ConfigureCompositionRoot() {
            CompositionRoot compositionRoot = new CompositionRoot();
            compositionRoot.CompositionRootGenerator();
            compositionRoot.DependencyResolver();
        }
    }
}
