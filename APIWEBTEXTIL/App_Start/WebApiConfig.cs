using CRUDTextil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIWEBTEXTIL
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de Web API
            // Rutas de Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "ProductosAPI",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { url = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
             name: "ProoveedoresAPI",
             routeTemplate: "api/{controller}/{id}",
            defaults: new { url = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
            name: "Pedidos_ProveedoresAPI",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { url = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
            name: "DetallesPedidosProveedoresAPI",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { url = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
            name: "EntradasInventarioAPI",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { url = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
            name: "AlmacenAPI",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { url = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
            name: "DetallePedidoClienteAPI",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { url = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
            name: "SalidasInventarioAPI",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { url = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
            name: "EmpleadosAPI",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { url = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
            name: "ClienteAPI",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { url = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
            name: "DetallemanyAPI",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { url = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
            name: "EntregasClienteAPI",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { url = RouteParameter.Optional }
            );
        }
    }
}
