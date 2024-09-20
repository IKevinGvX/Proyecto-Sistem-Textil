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
    public class ClienteController : ApiController
    {
        private static ClientesTableAdapter adap = new ClientesTableAdapter();
        public Textil.ClientesDataTable getclien()
        {
            return adap.GetDataClientes();
        }
    }
}