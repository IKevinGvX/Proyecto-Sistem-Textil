using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Sistem_Textil
{
    public partial class FrmDetalle_Pedidos : System.Web.UI.Page
    {
        CRUDTextil.detalle_pedidos deta = new CRUDTextil.detalle_pedidos();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvdeta.DataSource = deta.GetDataDetallePedidoE();
            dgvdeta.DataBind();
        }
        protected void BtnEnviar_Click1(object sender, EventArgs e)
        {
            var proee = deta.GetDataByIDDetallesEE(Convert.ToInt32(txtid.Text));
            if (proee.Rows.Count == 0)
            {
                lblmensaje.Text = "Compra Al Proovedor Inexistente, Verifica Codigo Compra";
                return;
            }
            else
            {
                lblmensaje.Text = "Compra Al Proovedor  Encontrado : " + " " + txtid.Text;
            }
        }
    }
}