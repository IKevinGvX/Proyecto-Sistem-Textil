using CRUDTextil.TextilTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTextil
{
    public class Entradas_inventario
    {
        private static EntradasInventarioTableAdapter entradas = new EntradasInventarioTableAdapter();
        public Textil.EntradasInventarioDataTable GetDataEntradasInventario()
        {
            return entradas.GetDataEntradasInventario();
        }
        public Textil.EntradasInventarioDataTable GetDataByEntradasID(int entre)
        {
            return entradas.GetDataByEntradasID(entre);
        }
    }
}
