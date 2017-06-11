using System;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;

namespace TestWebApi {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Configuration et services API Web
            config.Formatters.JsonFormatter.MediaTypeMappings.Add(new RequestHeaderMapping(
                "Accept",
                "text/html",
                StringComparison.InvariantCultureIgnoreCase,
                true,
                "application/json"
            ));

            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
