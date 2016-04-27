
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicio;
using Insfrastructura;
using System.Web.Http;
using Dominio;
using System.Reflection;
using Autofac.Builder;
using System.Security;
using WebApiMVC4.App_Start;
using WebApiMVC4.Controllers;
using Autofac.Integration.WebApi;


namespace WebApiMVC4.App_Start
{
    public class AutofacWebApiConfig
    {
        public static void RegisterAutofacApi()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(config);

            builder.RegisterType<ClientController>().As<ApiController>();
            builder.RegisterType<Operacion>().As<IOperacion>();
            builder.RegisterType<AppContext>().As<IRepository>();

            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

        }
    }
}