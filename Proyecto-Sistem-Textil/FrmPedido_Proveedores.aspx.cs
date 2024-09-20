using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Sistem_Textil
{
    public partial class FrmPedido_Proveedores : System.Web.UI.Page
    {
        CRUDTextil.PedidosProveedores cru = new CRUDTextil.PedidosProveedores();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvpedidoproveedores.DataSource = cru.GetDataPedidoProveedor();
            dgvpedidoproveedores.DataBind();
        }
        protected void BtnEnviar_Click1(object sender, EventArgs e)
        {
            var proee = cru.GetDataByIDProveedores(Convert.ToInt32(txtid.Text));
            if (proee.Rows.Count == 0)
            {
                lblmensaje.Text = "Detalle Pedido Inexistente, Verifica Codigo Detalle";
                return;
            }
            else
            {
                lblmensaje.Text = "Detalle Pedido  Encontrado : " + " " + txtid.Text;
            }
        }
    }
}