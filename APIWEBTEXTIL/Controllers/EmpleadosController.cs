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
    public class EmpleadosController : ApiController
    {
        private static EmpleadosTableAdapter emp = new EmpleadosTableAdapter();
        public Textil.EmpleadosDataTable getempleados()
        {
            return emp.GetDataEmpleados();
        }
    }
}