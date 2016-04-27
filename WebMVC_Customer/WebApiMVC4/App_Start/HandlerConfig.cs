using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.ObjectModel;
using System.Net.Http;
using YourApplication.MessageHandlers;

namespace WebApiMVC4.App_Start
{
    public class HandlerConfig
    {
        public static void RegisterHandlers(Collection<DelegatingHandler> handlers)
        {
            handlers.Add(new CorsHandler());
        }
    }
}