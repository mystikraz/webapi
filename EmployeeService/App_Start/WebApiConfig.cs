using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Serialization;
using WebApiContrib.Formatting.Jsonp;
using RouteParameter = System.Web.Http.RouteParameter;

namespace EmployeeService
{
    public static class WebApiConfig
    {
        
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            EnableCorsAttribute cors = new EnableCorsAttribute("*","*","*"); //("http://localhost:8072/","*","GET","post");
//            config.EnableCors(cors);
            config.EnableCors();
//            config.Filters.Add(new RequireHttpsAttribute());

//            var jsonpFormatter = new JsonpMediaTypeFormatter(config.Formatters.JsonFormatter);
//            config.Formatters.Insert(0,jsonpFormatter);

            ////indent json data
            //config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

            //camel case instead of pasal case
            //config.Formatters.JsonFormatter.SerializerSettings.ContractResolver=new CamelCasePropertyNamesContractResolver();
           
            ////to remove xml formatter
            //config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
