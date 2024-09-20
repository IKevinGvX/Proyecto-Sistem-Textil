using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.Http;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Sistem_Textil
{
    public partial class Acceso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void BtnEnviar_Click1(object sender, EventArgs e)
        {
            ServiceReference3.testSoapClient es = new ServiceReference3.testSoapClient();
            if (!es.validarusuarioempleado(txtnombre.Text, txtDNI.Text))
            {
                lblmensaje.Text = "Usuario O Dni Incorrectos";
                txtDNI.Text = ""; txtnombre.Text = "";
                return;
            }
            else
            {
                string dni = txtDNI.Text;
                Response.Redirect("Principal.aspx");
                Response.Redirect("Principal.aspx?txtDNI=" +  dni);
            }
        }

    }
}