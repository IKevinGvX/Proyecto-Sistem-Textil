using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Sistem_Textil
{
    public partial class FrmSalida : System.Web.UI.Page
    {
        CRUDTextil.SalidasInventario salida = new CRUDTextil.SalidasInventario();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvsalida.DataSource = salida.GetDataSalidaINventario();
            dgvsalida.DataBind();
        }
        protected void BtnEnviar_Click1(object sender, EventArgs e)
        {
            var salidas = salida.GetDataBySalidaInventarioID(Convert.ToInt32(txtid.Text));
            if (salidas.Rows.Count == 0)
            {
                lblmensaje.Text = "Salida Inexistente, Verifica Codigo Salida";
                return;
            }
            else
            {
                lblmensaje.Text = "Encontrado Salida : " + " " + txtid.Text;
            }
        }
    }
}