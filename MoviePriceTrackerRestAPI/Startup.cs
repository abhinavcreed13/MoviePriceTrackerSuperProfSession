using Owin;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MoviePriceTrackerRestAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // register my own middlewares

            var config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{action}/{id}",
                    defaults: new { action = "Get", id = RouteParameter.Optional }
                );

            //XML thing
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            app.UseWebApi(config);


        }
    }
}