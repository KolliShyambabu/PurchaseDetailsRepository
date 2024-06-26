﻿using Newtonsoft.Json.Serialization;
using PurchaseDetails.DAL.Interfaces;
using PurchaseDetails.DAL.Services;
using PurchaseDetails.DAL.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;
using Unity.AspNet.WebApi;

namespace PurchaseDetails
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "Default",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            var container = new UnityContainer();

            // Register your dependencies, including IExpenseService
            //container.RegisterType<IPurchaseDetailsService, PurchaseDetailsService>();
            // container.RegisterType<IPurchaseDetailsRepository, PurchaseDetailsRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            //By default Web API return XML data
            //We can remove this by clearing the SupportedMediaTypes option as follows
            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            //Now set the serializer setting for JsonFormatter to Indented to get Json Formatted data
            config.Formatters.JsonFormatter.SerializerSettings.Formatting =
                Newtonsoft.Json.Formatting.Indented;

            //For converting data in Camel Case
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
                new CamelCasePropertyNamesContractResolver();
        }
    }


}

        
