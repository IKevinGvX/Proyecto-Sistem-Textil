using CRUDTextil;
using CRUDTextil.TextilTableAdapters;
using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Services;
using System.Web.UI.HtmlControls;

namespace Proyecto_Sistem_Textil
{
    /// <summary>
    /// Descripción breve de test
    /// </summary>
    [WebService(Namespace = "http://testteobasededatos.asmx")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class test : System.Web.Services.WebService
    {
        private static SalidasInventarioTableAdapter salidas = new SalidasInventarioTableAdapter();
        private static Pedidos_ProveedoresTableAdapter provee = new Pedidos_ProveedoresTableAdapter();
        private static ProductosTableAdapter producto = new ProductosTableAdapter();
        private static ProveedoresTableAdapter proveedor = new ProveedoresTableAdapter();
        private static EntregasTableAdapter entregas = new EntregasTableAdapter();
        private static EntradasInventarioTableAdapter entradas = new EntradasInventarioTableAdapter();
        private static EmpleadosTableAdapter employees = new EmpleadosTableAdapter();
        private static DetallesPedidoClienteTableAdapter client = new DetallesPedidoClienteTableAdapter();
        private static detalles_pedidosTableAdapter pedidos = new detalles_pedidosTableAdapter();
        private static AlmacenTableAdapter almacen = new AlmacenTableAdapter();
        private static ClientesTableAdapter clientes = new ClientesTableAdapter();
        private static detalles_many_entregasTableAdapter detalles = new detalles_many_entregasTableAdapter();
        private static CRUDTextil.validacionusuario val = new validacionusuario();
        [WebMethod]
        public bool validarusuarioempleado(string nombre, string dni)
        {
            return val.validarusuarioempleado(nombre, dni);
        }
        
        [WebMethod]
        public Textil.AlmacenDataTable GetDataAlmacen()
        {
            return almacen.GetDataAlmacen();
        }
        [WebMethod]
        public Textil.AlmacenDataTable GetDataByIDAlmacen(int id)
        {
            return almacen.GetDataByIDAlmacen(id);
        }
        [WebMethod]
        public Textil.ClientesDataTable GetDataClientes()
        {
            return clientes.GetDataClientes();
        }
        [WebMethod]
        public Textil.ClientesDataTable GetDataByClientesID(int idcliente)
        {
            return clientes.GetDataByClientesID(idcliente);
        }
        [WebMethod]
        public Textil.detalles_many_entregasDataTable GetDataDetallesManhy()
        {
            return detalles.GetDataDetallesManhy();
        }
        [WebMethod]
        public Textil.detalles_many_entregasDataTable GetDataByIDManyDetalles(int iddetalles)
        {
            return detalles.GetDataByIDManyDetalles(iddetalles);
        }
        [WebMethod]
        public Textil.detalles_pedidosDataTable GetDataDetallePedidoE()
        {
            return pedidos.GetDataDetallePedidoE();
        }
        [WebMethod]
        public Textil.DetallesPedidoClienteDataTable GetDataDetallePedidoCliente()
        {
            return client.GetDataDetallePedidoCliente();
        }
        [WebMethod]
        public Textil.DetallesPedidoClienteDataTable GetDataByIDDetalleCliente(int cliente)
        {
            return client.GetDataByIDDetalleCliente(cliente);
        }
        [WebMethod]
        public Textil.EmpleadosDataTable GetDataEmpleados()
        {
            return employees.GetDataEmpleados();
        }
        [WebMethod]
        public Textil.EmpleadosDataTable GetDataByIDEmpleados(int employ)
        {
            return employees.GetDataByIDEmpleados(employ);
        }
        [WebMethod]
        public Textil.EntradasInventarioDataTable GetDataEntradasInventario()
        {
            return entradas.GetDataEntradasInventario();
        }
        [WebMethod]
        public Textil.EntradasInventarioDataTable GetDataByEntradasID(int entre)
        {
            return entradas.GetDataByEntradasID(entre);
        }
        [WebMethod]
        public Textil.EntregasDataTable GetDataEntregas()
        {
            return entregas.GetDataEntregas();
        }
        [WebMethod]
        public Textil.EntregasDataTable GetDataByIDEntregas(int entreg)
        {
            return entregas.GetDataByIDEntregas(entreg);
        }
        [WebMethod]
        public Textil.Pedidos_ProveedoresDataTable GetDataPedidoProveedor()
        {
            return provee.GetDataPedidoProveedor();
        }
        [WebMethod]
        public Textil.Pedidos_ProveedoresDataTable GetDataByIDProveedores(int pedidos)
        {
            return provee.GetDataByIDProveedores(pedidos);
        }
        [WebMethod]
        public Textil.ProductosDataTable GetDataProductos()
        {
            return producto.GetDataProductos();
        }
        [WebMethod]
        public Textil.ProductosDataTable GetDataByIDProducto(int pro)
        {
            return producto.GetDataByIDProducto(pro);
        }
        [WebMethod]
        public Textil.ProveedoresDataTable GetDataProveedores()
        {
            return proveedor.GetDataProveedores();
        }
        [WebMethod]
        public Textil.ProveedoresDataTable GetDataByIDProveedore(int prove)
        {
            return proveedor.GetDataByIDProveedore(prove);
        }
        [WebMethod]
        public Textil.SalidasInventarioDataTable GetDataSalidaINventario()
        {
            return salidas.GetDataSalidaINventario();
        }
        [WebMethod]
        public Textil.SalidasInventarioDataTable GetDataBySalidaInventarioID(int id)
        {
            return salidas.GetDataBySalidaInventarioID(id);
        }
    }
}
