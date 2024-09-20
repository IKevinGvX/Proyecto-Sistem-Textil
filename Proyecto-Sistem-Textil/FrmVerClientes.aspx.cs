using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Sistem_Textil
{
    public partial class FrmVerClientes : System.Web.UI.Page
    {
        CRUDTextil.Clientes cli = new CRUDTextil.Clientes();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvclientes.DataSource = cli.GetDataClientes();
            dgvclientes.DataBind();
        }
        protected void BtnEnviar_Click1(object sender, EventArgs e)
        {
            var prode = cli.GetDataByClientesID(Convert.ToInt32(txtid.Text));
            if (prode.Rows.Count == 0)
            {
                lblmensaje.Text = "Cliente Inexistente, Verifica Codigo Cliente";
                return;
            }
            else
            {
                lblmensaje.Text = "Encontrado Cliente : " + " " + txtid.Text;
            }
        }
    }
}