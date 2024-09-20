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
    public class DetallePedidoClienteController : ApiController
    {
        private static DetallesPedidoClienteTableAdapter adap = new DetallesPedidoClienteTableAdapter();
        public Textil.DetallesPedidoClienteDataTable getdetapedidocl()
        {
            return adap.GetDataDetallePedidoCliente();
        }
    }
}