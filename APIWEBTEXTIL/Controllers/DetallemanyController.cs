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
    public class DetallemanyController : ApiController
    {
        protected static detalles_many_entregasTableAdapter adap = new detalles_many_entregasTableAdapter();
        public Textil.detalles_many_entregasDataTable getmany()
        {
            return adap.GetDataDetallesManhy();
        }
    }
}