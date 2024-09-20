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
    public class Pedidos_ProveedoresController : ApiController
    {
        // GET: Pedidos_Proveedores
        private static Pedidos_ProveedoresTableAdapter adap = new Pedidos_ProveedoresTableAdapter();
        public Textil.Pedidos_ProveedoresDataTable GetPedidos_Proveedores()
        {
            return adap.GetDataPedidoProveedor();
        }
    }
}