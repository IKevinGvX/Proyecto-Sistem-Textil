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
    public class ProoveedoresController : ApiController
    {
        // GET: Prooveedores
        public static ProveedoresTableAdapter provee = new ProveedoresTableAdapter();
        public Textil.ProveedoresDataTable GetProveedores()
        {
            return provee.GetDataProveedores();
        }
    }
}