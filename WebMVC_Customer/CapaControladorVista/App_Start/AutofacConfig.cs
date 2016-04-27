using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Servicio;
using Insfrastructura;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using System.Reflection;
using CapaControladorVista.Controllers;

namespace CapaControladorVista
{
    public static class AutofacConfig
    {                                        //vacio si linia 33 activada y linia 32 desact
        public static void RegisterAutofac ()
	    {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinders();
            builder.RegisterAssemblyModules(typeof(MvcApplication).Assembly);

            builder.RegisterType<MantenimentoClientesController>().As<Controller>().InstancePerHttpRequest();
            builder.RegisterType<Operacion>().As<IOperacion>().InstancePerHttpRequest();
            builder.RegisterType<AppContext>().As<IRepository>().InstancePerHttpRequest();

            var container = builder.Build();
            //SetResolver(new AutofacDependencyResolver(container));
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            
	    }



        
    }
}