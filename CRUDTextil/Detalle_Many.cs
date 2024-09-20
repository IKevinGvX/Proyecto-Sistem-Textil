using CRUDTextil.TextilTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTextil
{
    public class Detalle_Many
    {
        private static detalles_many_entregasTableAdapter detalles = new detalles_many_entregasTableAdapter();
        public Textil.detalles_many_entregasDataTable GetDataDetallesManhy()
        {
            return detalles.GetDataDetallesManhy();
        }
        public Textil.detalles_many_entregasDataTable GetDataByIDManyDetalles(int iddetalles)
        {
            return detalles.GetDataByIDManyDetalles(iddetalles);
        }
    }
}
