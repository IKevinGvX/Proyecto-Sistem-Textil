using CRUDTextil.TextilTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTextil
{
    public class SalidasInventario
    {
        private static SalidasInventarioTableAdapter salidas = new SalidasInventarioTableAdapter();
        public Textil.SalidasInventarioDataTable GetDataSalidaINventario()
        {
            return salidas.GetDataSalidaINventario();
        }
        public Textil.SalidasInventarioDataTable GetDataBySalidaInventarioID(int id)
        {
            return salidas.GetDataBySalidaInventarioID(id);
        }
    }
}
