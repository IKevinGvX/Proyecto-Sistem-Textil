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
    public class AlmacenController : ApiController
    {
        private static AlmacenTableAdapter adapter = new AlmacenTableAdapter();
        public Textil.AlmacenDataTable getalmacen()
        {
            return adapter.GetDataAlmacen();
        }
    }
}