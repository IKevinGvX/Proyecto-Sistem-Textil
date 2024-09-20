using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TexilServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ServicioTextil
    {

        [OperationContract]
        string ValidacionProveedor(int proveedorid, string nombre, string contacto, string telefono, string email, string direccion);
        [OperationContract]
        string EstadoPedidoCompra(string nombre, string contacto, string estado, string fecha, int cantidad, int productoid);
        [OperationContract]
        string detallepedido(int pedidoid, int productoid, int cantidad);
        [OperationContract]
        string entradainventario(string fechaentrega, int productoid, int cantidad, int proveedorid, int almacenid);
        [OperationContract]
        string almacen(string ubicacion, string referencia, int cantidad);
        [OperationContract]
        string Productos(string nombre, string descripcion, string categoria, int stock, string ubicacion);
        [OperationContract]
        string salidainventario(string feche_salida, int empleadoid, int productoid, int stock);
        [OperationContract]
        string Empleado(string nombre, string apellido, string dni, string rango, string fecha, string email, string sueldo, string telefono);
        [OperationContract]
        string Clientes(string nombre, string apellido, string dni, string fecha, string telefono, string ruc, string email, string ubicacion);
        [OperationContract]
        string DetallesPedidoCliente(string productoid, string cantidad, string clienteid, string fechapedido, string estado);
        [OperationContract]
        string Entregas(string fecha);
        [OperationContract]
        string detallemany_entrega(string productoid, string cantidad, string fechapedido, string estado, string pedidomany, string entreid, string fechaentrega);


    }
}
