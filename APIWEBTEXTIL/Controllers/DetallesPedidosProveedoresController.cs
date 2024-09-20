using CRUDTextil;
using CRUDTextil.TextilTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace APIWEBTEXTIL.Controllers
{
    public class DetallesPedidosProveedoresController : ApiController
    {
        // GET: detalles_pedidos
        private static detalles_pedidosTableAdapter detalles = new detalles_pedidosTableAdapter();
        public Textil.detalles_pedidosDataTable Getdetalles()
        {
            return detalles.GetDataDetallePedido();
        }
    }
}