using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace Oregon.UI
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            if (config == null) throw new ArgumentNullException(nameof(config));
            // Web API configuration and services
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            // Web API routes
            config = GlobalConfiguration.Configuration;

            config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;


            config.Formatters.XmlFormatter.UseXmlSerializer = true;

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
            name: "Index",
            routeTemplate: "{id}.html",
            defaults: new { id = "index" });

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/v1/{controller}/{action}/"
            );
        }
    }
}