using CRUDTextil.TextilTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTextil
{
    public class Almacen
    {


        //PROCEDIMIENTOS OBTENCION DE DATOS
        private static AlmacenTableAdapter almacen = new AlmacenTableAdapter();


        public Textil.AlmacenDataTable GetDataAlmacen()
        {
            return almacen.GetDataAlmacen();
        }
        public Textil.AlmacenDataTable GetDataByIDAlmacen(int id)
        {
            return almacen.GetDataByIDAlmacen(id);
        }
    }
}
