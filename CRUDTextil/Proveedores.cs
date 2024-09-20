using CRUDTextil.TextilTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTextil
{
    public class Proveedores
    {
        private static ProveedoresTableAdapter provee = new ProveedoresTableAdapter(); 
        public Textil.ProveedoresDataTable GetDataProveedores()
        {
            return provee.GetDataProveedores();
        }
        public Textil.ProveedoresDataTable GetDataByIDProveedore(int prove)
        {
            return provee.GetDataByIDProveedore(prove);
        }
    }
}
