using CRUDTextil.TextilTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTextil
{
    public class detalle_pedidos
    {
        private static detalles_pedidosTableAdapter pedidos = new detalles_pedidosTableAdapter();
        public Textil.detalles_pedidosDataTable GetDataDetallePedidoE()
        {
            return pedidos.GetDataDetallePedidoE();
        }
        public Textil.detalles_pedidosDataTable GetDataByIDDetallesEE(int id)
        {
            return pedidos.GetDataByIDDetallesEE(id);
        }
    }
}
