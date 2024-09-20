using CRUDTextil;
using CRUDTextil.TextilTableAdapters;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;

namespace APIWEBTEXTIL.Controllers
{
    public class ProductosController : ApiController
    {
        //Funcion Listar Y Obtencion Datos (Get)
        private static ProductosTableAdapter producto = new ProductosTableAdapter();
        public Textil.ProductosDataTable GetDataProductos()
        {
            return producto.GetDataProductos();
        }

    }
        
    
}