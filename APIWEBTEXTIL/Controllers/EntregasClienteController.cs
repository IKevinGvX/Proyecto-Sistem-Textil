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
    public class EntregasClienteController : ApiController
    {
        protected static EntregasTableAdapter adap = new EntregasTableAdapter();
        public Textil.EntregasDataTable getentregas()
        {
            return adap.GetDataEntregas();
        }
    }
}