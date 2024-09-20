using CRUDTextil.TextilTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTextil
{
    public class Entregas
    {
        private static EntregasTableAdapter entregas = new EntregasTableAdapter();
        public Textil.EntregasDataTable GetDataEntregas()
        {
            return entregas.GetDataEntregas();
        }
        public Textil.EntregasDataTable GetDataByIDEntregas(int entreg)
        {
            return entregas.GetDataByIDEntregas(entreg);
        }
    }
}
