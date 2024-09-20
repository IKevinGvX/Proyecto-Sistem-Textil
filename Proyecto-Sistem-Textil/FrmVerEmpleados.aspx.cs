using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Sistem_Textil
{
    public partial class FrmVerEmpleados : System.Web.UI.Page
    {
        CRUDTextil.Empleados emp = new CRUDTextil.Empleados();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvempleados.DataSource = emp.GetDataEmpleados();
            dgvempleados.DataBind();
        }

        protected void btnenviar_Click1(object sender, EventArgs e)
        {
            
        }

        protected void BtnEnviar_Click1(object sender, EventArgs e)
        {
            var prode = emp.GetDataByIDEmpleados(Convert.ToInt32(txtid.Text));
            if(prode.Rows.Count == 0)
            {
                lblmensaje.Text = "Empleado Inexistente, Verifica Codigo Empleado";
                return;
            }
            else
            {
                lblmensaje.Text = "Encontrado Empleado : " + " " + txtid.Text;
            }
        }
    }
}