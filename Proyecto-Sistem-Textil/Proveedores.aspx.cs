using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Sistem_Textil
{
    public partial class Proveedores : System.Web.UI.Page
    {
        CRUDTextil.Proveedores prove = new CRUDTextil.Proveedores();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvproveedores.DataSource = prove.GetDataProveedores();
            dgvproveedores.DataBind();
        }
        protected void BtnEnviar_Click1(object sender, EventArgs e)
        {
            var prode = prove.GetDataByIDProveedore(Convert.ToInt32(txtid.Text));
            if (prode.Rows.Count == 0)
            {
                lblmensaje.Text = "Proveedor Inexistente, Verifica Codigo Proveedor";
                return;
            }
            else
            {
                lblmensaje.Text = "Encontrado Proveedor : " + " " + txtid.Text;
            }
        }
    }
}