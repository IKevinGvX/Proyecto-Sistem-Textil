using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Sistem_Textil
{
    public partial class FrmVerAlmacen : System.Web.UI.Page
    {
        CRUDTextil.Almacen am = new CRUDTextil.Almacen();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvalmacen.DataSource = am.GetDataAlmacen();
            dgvalmacen.DataBind();
        }
        protected void BtnEnviar_Click1(object sender, EventArgs e)
        {
            var prode = am.GetDataByIDAlmacen(Convert.ToInt32(txtid.Text));
            if (prode.Rows.Count == 0)
            {
                lblmensaje.Text = "Almacen Inexistente, Verifica Codigo Almacen";
                return;
            }
            else
            {
                lblmensaje.Text = "Encontrado Almacen : " + " " + txtid.Text;
            }
        }
    }
    
}