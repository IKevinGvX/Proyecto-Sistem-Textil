using CRUDTextil.TextilTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTextil
{
    public class DetallePedido_Cliente
    {
        private static DetallesPedidoClienteTableAdapter client = new DetallesPedidoClienteTableAdapter();
        public Textil.DetallesPedidoClienteDataTable GetDataDetallePedidoCliente()
        {
            return client.GetDataDetallePedidoCliente();
        }
        public Textil.DetallesPedidoClienteDataTable GetDataByIDDetalleCliente(int cliente)
        {
            return client.GetDataByIDDetalleCliente(cliente);
        }

    }
}
