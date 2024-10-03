using CRUDTextil;
using CRUDTextil.TextilTableAdapters;
using Proyecto_Sistem_Textil.ServiceReference1;
using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Proyecto_Sistem_Textil
{
    public partial class Principal : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void Vistaproductop_click(object sender, EventArgs e)
        {
            ServiceReference2.testSoapClient servicio = new ServiceReference2.testSoapClient();
            servicio.GetDataAlmacen();

        }
    }
}