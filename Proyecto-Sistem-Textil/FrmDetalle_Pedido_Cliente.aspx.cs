using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Sistem_Textil
{
    public partial class FrmDetalle_Pedido_Cliente : System.Web.UI.Page
    {
        CRUDTextil.DetallePedido_Cliente dpt = new CRUDTextil.DetallePedido_Cliente();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvdetalleentrega.DataSource = dpt.GetDataDetallePedidoCliente();
            dgvdetalleentrega.DataBind();
        }
        protected void BtnEnviar_Click1(object sender, EventArgs e)
        {
            var salidas = dpt.GetDataByIDDetalleCliente(Convert.ToInt32(txtid.Text));
            if (salidas.Rows.Count == 0)
            {
                lblmensaje.Text = "Detalle Pedido CLIENTE Inexistente, Verifica Codigo Detalle Pedido CLIENTE ";
                return;
            }
            else
            {
                lblmensaje.Text = "Detalle Pedido CLIENTE  : " + " " + txtid.Text;
            }
        }
    }
}