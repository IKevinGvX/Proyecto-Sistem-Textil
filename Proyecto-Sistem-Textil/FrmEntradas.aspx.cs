using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Sistem_Textil
{
    public partial class FrmEntradas : System.Web.UI.Page
    {
        CRUDTextil.Entradas_inventario entra = new CRUDTextil.Entradas_inventario();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgventrada.DataSource = entra.GetDataEntradasInventario();
            dgventrada.DataBind();
        }
        protected void BtnEnviar_Click1(object sender, EventArgs e)
        {
            var prode = entra.GetDataByEntradasID(Convert.ToInt32(txtid.Text));
            if (prode.Rows.Count == 0)
            {
                lblmensaje.Text = "Entradas Inexistente, Verifica Codigo Entrada";
                return;
            }
            else
            {
                lblmensaje.Text = "Encontrado Entrada De Codigo : " + " " + txtid.Text;
            }
        }
    }
}