using CRUDTextil.TextilTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTextil
{
    public class PedidosProveedores
    {
        private static Pedidos_ProveedoresTableAdapter provee = new Pedidos_ProveedoresTableAdapter();
        public Textil.Pedidos_ProveedoresDataTable GetDataPedidoProveedor()
        {
            return provee.GetDataPedidoProveedor();
        }
        public Textil.Pedidos_ProveedoresDataTable GetDataByIDProveedores(int pedidos)
        {
            return provee.GetDataByIDProveedores(pedidos);
        }
    }
}
