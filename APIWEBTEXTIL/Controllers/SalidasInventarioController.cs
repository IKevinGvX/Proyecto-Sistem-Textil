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
    public class SalidasInventarioController : ApiController
    {
        private static SalidasInventarioTableAdapter adap = new SalidasInventarioTableAdapter();
        public Textil.SalidasInventarioDataTable getsalidas()
        {
            return adap.GetDataSalidaINventario();
        }
    }
}