using CRUDTextil.TextilTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTextil
{
    public class Clientes
    {
        private static ClientesTableAdapter clientes = new ClientesTableAdapter();
        public Textil.ClientesDataTable GetDataClientes()
        {
            return clientes.GetDataClientes();
        }
        public Textil.ClientesDataTable GetDataByClientesID(int clientesid)
        {
            return clientes.GetDataByClientesID(clientesid);
        }
    }
}
