using CRUDTextil.TextilTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTextil
{
    public class Productos
    {
        private static ProductosTableAdapter producto = new ProductosTableAdapter();
        public Textil.ProductosDataTable GetDataProductos()
        {
            return producto.GetDataProductos();
        }
        public Textil.ProductosDataTable GetDataByIDProducto(int pro)
        {
            return producto.GetDataByIDProducto(pro);
        }
    }
}
