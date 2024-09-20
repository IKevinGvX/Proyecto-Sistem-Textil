using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Proyecto_Sistem_Textil
{
    public partial class Producto : System.Web.UI.Page
    { 
        
        CRUDTextil.Productos pro = new CRUDTextil.Productos();

        
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvproducto.DataSource = pro.GetDataProductos();
            dgvproducto.DataBind();
        }

        protected void BtnEnviar_Click1(object sender, EventArgs e  )
        {
            var proee = pro.GetDataByIDProducto(Convert.ToInt32(txtid.Text));
            if (proee.Rows.Count == 0)
            {
                lblmensaje.Text = "Producto Inexistente, Verifica Codigo Producto";
                return;
            }
            else
            {
                lblmensaje.Text = "Producto Encontrado : " + " " + txtid.Text;
            }
        }
    }
}