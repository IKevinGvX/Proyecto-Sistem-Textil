using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Sistem_Textil
{
    public partial class FrmEntregas : System.Web.UI.Page
    {
        CRUDTextil.Entregas enrtre = new CRUDTextil.Entregas();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgventradas.DataSource = enrtre.GetDataEntregas();
            dgventradas.DataBind();
        }
        protected void BtnEnviar_Click1(object sender, EventArgs e)
        {
            var salidas = enrtre.GetDataByIDEntregas(Convert.ToInt32(txtid.Text));
            if (salidas.Rows.Count == 0)
            {
                lblmensaje.Text = "Entrega Inexistente, Verifica Codigo Inexistente";
                return;
            }
            else
            {
                lblmensaje.Text = "Entregas Salida : " + " " + txtid.Text;
            }
        }
    }
}