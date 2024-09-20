        using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TexilServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : ServicioTextil
    {
        SqlConnection conex = new SqlConnection("Data Source = DESKTOP-FFTCVLK\\DEVELOPEKEV;Initial Catalog= textil ; Integrated Security =true;");

        public string ValidacionProveedor(int proveedorid, string nombre, string contacto, string telefono, string email, string direccion)
        {
            string mensaje = "";
            List<int> listaint = new List<int>();
            List<string> lista = new List<string>();
            {
                conex.Open();
                SqlCommand comando = new SqlCommand("select * from Proveedores where ProveedorID = @proveedorid  and Nombre = @nombre and Contacto = @Contacto and Telefono = @Telefono and Email = @Email and Direccion = @Direccion", conex);
                comando.Parameters.AddWithValue("@proveedorid", proveedorid);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@Contacto", contacto);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@Direccion", direccion);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    mensaje = "Proveedor Encontrado : " + nombre;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int provee = Convert.ToInt32(dt.Rows[i]["ProveedorID"].ToString());
                        string name = dt.Rows[i]["Nombre"].ToString();
                        string contacte = dt.Rows[i]["Contacto"].ToString();
                        string telefone = dt.Rows[i]["Telefono"].ToString();
                        string emaile = dt.Rows[i]["Email"].ToString();
                        string direcc = dt.Rows[i]["Direccion"].ToString();
                        listaint.Add(provee); lista.Add(name); lista.Add(contacte); lista.Add(telefone);
                        lista.Add(emaile); lista.Add(direcc);
                    }
                }
                else
                {
                    mensaje = "Proveedor No Encontrado";
                }
                conex.Close();
            }
            return mensaje;
        }
        public string EstadoPedidoCompra(string nombre,string contacto ,string estado, string fecha,int cantidad,int productoid)
        {
            string mensaje = "";
            List<int> listaint = new List<int>();
            List<string> lista = new List<string>();
            {
                conex.Open();
                SqlCommand comando = new SqlCommand("select p.Nombre,p.Contacto,pp.Estado,pp.FechaPedido,dp.Cantidad,dp.ProductoID  from Proveedores p inner join Pedidos_Proveedores pp inner join detalles_pedidos dp  on dp.PedidoID = pp.PedidoID on pp.ProveedorID = p.ProveedorID where P.Nombre = @nombre and p.Contacto = @contacto and pp.Estado = @estado and pp.FechaPedido = @fecha and dp.Cantidad = @cantidad and dp.ProductoID = @productoid", conex);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@contacto", contacto);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@productoid", productoid);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    mensaje = "Detalle El Estado Fue  : " + estado;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string Nombre = dt.Rows[i]["Nombre"].ToString();
                        string name = dt.Rows[i]["Contacto"].ToString();
                        string contacte = dt.Rows[i]["Estado"].ToString();
                        string telefone = dt.Rows[i]["FechaPedido"].ToString();
                        string emaile = dt.Rows[i]["Cantidad"].ToString();
                        string direcc = dt.Rows[i]["ProductoID"].ToString();
                        lista.Add(Nombre); lista.Add(name); lista.Add(contacte); lista.Add(telefone);
                        lista.Add(emaile); lista.Add(direcc);
                    }
                }
                else
                {
                    mensaje = "Detalle No Encontrado";
                }
                conex.Close();
            }
            return mensaje;
        }
        public string detallepedido(int pedidoid, int productoid, int cantidad)
        {
            string mensaje = "";
            List<int> lista = new List<int>();
            {
                conex.Open();
                SqlCommand com = new SqlCommand("select * from detalles_pedidos where PedidoID = @pedidoid and ProductoID = @productoid and Cantidad = @Cantidad",conex);
                com.Parameters.AddWithValue("@pedidoid", pedidoid);
                com.Parameters.AddWithValue("@productoid", productoid);
                com.Parameters.AddWithValue("@cantidad", cantidad);
                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable data =  new DataTable();
                adap.Fill(data);
                if(data.Rows.Count > 0)
                {
                    mensaje = " Detalle Pedido Es : " + pedidoid;
                    for(int i = 0; i < data.Rows.Count; i++)
                    {
                        int pedido = Convert.ToInt32(data.Rows[i]["PedidoID"].ToString());
                        int producto = Convert.ToInt32(data.Rows[i]["ProductoID"].ToString());
                        int canti = Convert.ToInt32(data.Rows[i]["Cantidad"].ToString());
                        lista.Add(pedido);lista.Add(producto);lista.Add(canti);
                    }
                }
                else
                {
                    mensaje = "Producto No Encontrado";
                }
                conex.Close();
            }
            return mensaje;
        }
        public string entradainventario(string fechaentrega,int productoid,int cantidad,int proveedorid,int almacenid)
        {
            string mensaje = "";
            List<int> lista = new List<int>();
            List<string>liston = new List<string>();
            {
                conex.Open();
                SqlCommand com = new SqlCommand("select * from EntradasInventario where FechaEntrada =@fechaentrega and ProductoID = @productoid     and Cantidad=@cantidad and ProveedorID = @proveedorid and AlmacenID=@almacenid" ,conex);
                com.Parameters.AddWithValue("@fechaentrega", fechaentrega);
                com.Parameters.AddWithValue("@productoid", productoid);
                com.Parameters.AddWithValue("@cantidad", cantidad);
                com.Parameters.AddWithValue("@proveedorid", proveedorid);
                com.Parameters.AddWithValue("@almacenid", almacenid);
                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable data = new DataTable();
                adap.Fill(data);
                if (data.Rows.Count > 0)
                {
                    mensaje = " Entrada Inventario Fecha : " + fechaentrega;
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        string pedidos = data.Rows[i]["FechaEntrada"].ToString();
                        int producto = Convert.ToInt32(data.Rows[i]["ProductoID"].ToString());
                        int canti = Convert.ToInt32(data.Rows[i]["Cantidad"].ToString());
                        int proveeid = Convert.ToInt32(data.Rows[i]["ProveedorID"].ToString());
                        int almacid = Convert.ToInt32(data.Rows[i]["AlmacenID"].ToString());
                        liston.Add(pedidos);lista.Add(producto); lista.Add(canti);
                        lista.Add(proveeid); lista.Add(almacenid);
                    }
                }
                else
                {
                    mensaje = "Entrada Inventario No Encontrado";
                }
                conex.Close();
            }
            return mensaje;
        }
        public string almacen(string ubicacion , string referencia , int cantidad)
        {
            string mensaje = "";
            List<int> lista = new List<int>();
            List<string> liston = new List<string>();
            {
                conex.Open();
                SqlCommand com = new SqlCommand("select * from Almacen where Ubicacion = @ubicacion and Referencia = @referencia and Cantidad =@cantidad", conex);
                com.Parameters.AddWithValue("@ubicacion", ubicacion);
                com.Parameters.AddWithValue("@referencia", referencia);
                com.Parameters.AddWithValue("@cantidad", cantidad);
                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable data = new DataTable();
                adap.Fill(data);
                if (data.Rows.Count > 0)
                {
                    mensaje = " Encontrado Almacen : " + ubicacion;
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        string Ubicacion = data.Rows[i]["Ubicacion"].ToString();
                        string refe = (data.Rows[i]["Referencia"].ToString());
                        int cat = Convert.ToInt32(data.Rows[i]["Cantidad"].ToString());
                        liston.Add(ubicacion);lista.Add(cat);liston.Add(refe);
                    }
                }
                else
                {
                    mensaje = "No Encontrado Almacen";
                }
                conex.Close();
            }
            return mensaje;
        }
        public string Productos(string nombre, string descripcion,string categoria , int stock,  string ubicacion)
        {
            string mensaje = "";
            List<int> lista = new List<int>();
            List<string> liston = new List<string>();
            {
                conex.Open();
                SqlCommand com = new SqlCommand("select * from Productos where Nombre=@nombre and Descripcion =@descripcion and Categoria =@categoria and Stock=@stock and Ubicacion =@ubicacion", conex);
                com.Parameters.AddWithValue("@nombre", nombre);
                com.Parameters.AddWithValue("@descripcion", descripcion);
                com.Parameters.AddWithValue("@categoria", categoria);
                com.Parameters.AddWithValue("@stock", stock);
                com.Parameters.AddWithValue("@ubicacion", ubicacion);
                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable data = new DataTable();
                adap.Fill(data);
                if (data.Rows.Count > 0)
                {
                    mensaje = " Producto Localizado : " + nombre;
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        string eee = data.Rows[i]["Nombre"].ToString();
                        string des = (data.Rows[i]["Descripcion"].ToString());
                        string cate = data.Rows[i]["Categoria"].ToString();
                        int stocke = Convert.ToInt32(data.Rows[i]["Stock"].ToString());
                        string ubi = data.Rows[i]["Ubicacion"].ToString();
                        liston.Add(eee);liston.Add(des);liston.Add(cate);lista.Add(stocke);
                        liston.Add(ubi);
                    }
                }
                else
                {
                    mensaje = "No Encontrado En La Tabla";
                }
                conex.Close();
            }
            return mensaje;
        }
        public string salidainventario(string feche_salida , int empleadoid, int productoid, int stock)
        {
            string mensaje = "";
            List<int> lista = new List<int>();
            List<string> liston = new List<string>();
            {
                conex.Open();
                SqlCommand com = new SqlCommand("select * from SalidasInventario where FechaSalida =@fecha_salida and EmpleadoID=@empleadoid and ProductoID=@productoid and Cantidad=@cantidad", conex);
                com.Parameters.AddWithValue("@fecha_salida", feche_salida);
                com.Parameters.AddWithValue("@empleadoid", empleadoid);
                com.Parameters.AddWithValue("@productoid", productoid);
                com.Parameters.AddWithValue("@cantidad", stock );
                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable data = new DataTable();
                adap.Fill(data);
                if (data.Rows.Count > 0)
                {
                    mensaje = " La Fecha Salida Es : " + feche_salida;
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        string fec = data.Rows[i]["FechaSalida"].ToString();
                        int emp = Convert.ToInt32(data.Rows[i]["EmpleadoID"].ToString());
                        int pr = Convert.ToInt32(data.Rows[i]["ProductoID"].ToString());
                        int ca = Convert.ToInt32(data.Rows[i]["Cantidad"].ToString());
                        liston.Add(fec);lista.Add(emp);lista.Add(pr);lista.Add(ca);
                    }
                }
                else
                {
                    mensaje = "Fecha No Enoncontrada";
                }
                conex.Close();
            }
            return mensaje;
        }
        public string Empleado(string nombre,string apellido,string dni,string rango,string fecha,string email ,string sueldo,string telefono)
        {
            string mensaje = "";
            List<string> liston = new List<string>();
            {
                conex.Open();
                SqlCommand com = new SqlCommand("select * from Empleados where Nombre = @nombre and Apellido =@apellido and DNI=@dni and Rango=@rango and Fecha=@fecha and Email=@email and Sueldo=@sueldo and Telefono=@telefono", conex);
                com.Parameters.AddWithValue("@nombre", nombre);
                com.Parameters.AddWithValue("@apellido", apellido);
                com.Parameters.AddWithValue("@dni", dni);
                com.Parameters.AddWithValue("@rango", rango);
                com.Parameters.AddWithValue("@fecha", fecha);
                com.Parameters.AddWithValue("@email", email);
                com.Parameters.AddWithValue("@sueldo", sueldo);
                com.Parameters.AddWithValue("@telefono", telefono);
                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable data = new DataTable();
                adap.Fill(data);
                if (data.Rows.Count > 0)
                {
                    mensaje = "Nombre y Apelldio Empleado : " + nombre + " " + apellido;
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        string name = data.Rows[i]["Nombre"].ToString();
                        string ape = data.Rows[i]["Apellido"].ToString();
                        string dne = data.Rows[i]["DNI"].ToString();
                        string rage = data.Rows[i]["Rango"].ToString();
                        string feche = data.Rows[i]["Fecha"].ToString();
                        string ema = data.Rows[i]["Email"].ToString();
                        string suel = data.Rows[i]["Sueldo"].ToString();
                        string tele = data.Rows[i]["Telefono"].ToString();
                    }
                }
                else
                {
                    mensaje = "Emplooyes Not Found";
                }
                conex.Close();
            }
            return mensaje;
        }
        public string Clientes(string nombre , string apellido,string dni ,string fecha,string telefono , string ruc , string email,string ubicacion)
        {
            string mensaje = "";
            List<string> liston = new List<string>();
            {
                conex.Open();
                SqlCommand com = new SqlCommand("select * from Clientes where Nombre = @nombre and Apellido =@apellido and DNI=@dni and Fecha=@fecha and Telefono=@telefono and Ruc=@ruc and Email=@email and Ubicacion=@ubicacion", conex);
                com.Parameters.AddWithValue("@nombre", nombre);
                com.Parameters.AddWithValue("@apellido", apellido);
                com.Parameters.AddWithValue("@dni", dni);
                com.Parameters.AddWithValue("@fecha", fecha);
                com.Parameters.AddWithValue("@telefono", telefono);
                com.Parameters.AddWithValue("@ruc", ruc);
                com.Parameters.AddWithValue("@email", email);
                com.Parameters.AddWithValue("@ubicacion", ubicacion);
                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable data = new DataTable();
                adap.Fill(data);
                if (data.Rows.Count > 0)
                {
                    mensaje = "Nombre y Apelldio Cliente : " + nombre + " " + apellido;
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        string name = data.Rows[i]["Nombre"].ToString();
                        string ape = data.Rows[i]["Apellido"].ToString();
                        string dne = data.Rows[i]["DNI"].ToString();
                        string rage = data.Rows[i]["Fecha"].ToString();
                        string feche = data.Rows[i]["Telefono"].ToString();
                        string ema = data.Rows[i]["Ruc"].ToString();
                        string suel = data.Rows[i]["Email"].ToString();
                        string tele = data.Rows[i]["Ubicacion"].ToString();
                    }
                }
                else
                {
                    mensaje = "Client Not Found";
                }
                conex.Close();
            }
            return mensaje;
        }
        public string DetallesPedidoCliente(string productoid , string cantidad , string clienteid,string fechapedido,string estado)
        {
            string mensaje = "";
            List<string> liston = new List<string>();
            {
                conex.Open();
                SqlCommand com = new SqlCommand("select * from DetallesPedidoCliente where ProductoID =@productoid and Cantidad=@cantidad and ClientesID=@clientesid and FechaPedido=@fechapedido and Estado=@estado\r\n", conex);
                com.Parameters.AddWithValue("@productoid", productoid);
                com.Parameters.AddWithValue("@cantidad", cantidad);
                com.Parameters.AddWithValue("@clientesid", clienteid);
                com.Parameters.AddWithValue("@fechapedido", fechapedido);
                com.Parameters.AddWithValue("@estado", estado);
                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable data = new DataTable();
                adap.Fill(data);
                if (data.Rows.Count > 0)
                {
                    mensaje = " Fecha Pedido :  " + fechapedido ;
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        string name = data.Rows[i]["ProductoID"].ToString();
                        string ape = data.Rows[i]["Cantidad"].ToString();
                        string dne = data.Rows[i]["ClientesID"].ToString();
                        string rage = data.Rows[i]["FechaPedido"].ToString();
                        string feche = data.Rows[i]["Estado"].ToString();
                    }
                }
                else
                {
                    mensaje = "DetallesPedidoCliente Not Found";
                }
                conex.Close();
            }
            return mensaje;
        }
        public string Entregas(string fecha)
        {
            string mensaje = "";
            List<string> liston = new List<string>();
            {
                conex.Open();
                SqlCommand com = new SqlCommand("select * from Entregas where FechaEntrega=@fechaentrega", conex);
                com.Parameters.AddWithValue("@fechaentrega", fecha);
                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable data = new DataTable();
                adap.Fill(data);
                if (data.Rows.Count > 0)
                {
                    mensaje = " Fecha Entregada El :  " + fecha;
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        string name = data.Rows[i]["FechaEntrega"].ToString();
                    }
                }
                else
                {
                    mensaje = "Entregas Not Found";
                }
                conex.Close();
            }
            return mensaje;
        }
        public string detallemany_entrega(string productoid,string cantidad,string fechapedido , string estado,string pedidomany,string entreid,string fechaentrega)
        {
            string mensaje = "";
            List<string> liston = new List<string>();
            {
                conex.Open();
                SqlCommand com = new SqlCommand("select * from  DetallesPedidoCliente p  inner join detalles_many_entregas ep inner join Entregas epe  on epe.EntregaID = ep.EntregaID on ep.DetallePedidoClienteID = p.DetallePedidoClienteID  where p.ProductoID=@productoid and p.Cantidad=@cantidad and p.FechaPedido=@fechapedido and p.Estado=@estado and ep.pedidomany=@pedidomany and ep.EntregaID=@entregaid and epe.FechaEntrega=@fechaentrega", conex);
                com.Parameters.AddWithValue("@productoid", productoid);
                com.Parameters.AddWithValue("@cantidad", cantidad);
                com.Parameters.AddWithValue("@fechapedido", fechapedido);
                com.Parameters.AddWithValue("@estado", estado);
                com.Parameters.AddWithValue("@pedidomany", pedidomany);
                com.Parameters.AddWithValue("@entregaid", entreid);
                com.Parameters.AddWithValue("@fechaentrega", fechaentrega);

                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable data = new DataTable();
                adap.Fill(data);
                if (data.Rows.Count > 0)
                {
                    mensaje = " Estado Del Entrega " + estado;
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        string prdo = data.Rows[i]["ProductoID"].ToString();
                        string can = data.Rows[i]["Cantidad"].ToString();
                        string fech = data.Rows[i]["FechaPedido"].ToString();
                        string esta = data.Rows[i]["Estado"].ToString();
                        string pedi = data.Rows[i]["pedidomany"].ToString();
                        string entreg = data.Rows[i]["EntregaID"].ToString();
                        string fechet = data.Rows[i]["FechaEntrega"].ToString();
                        liston.Add(prdo);liston.Add(can);liston.Add(fech);liston.Add(esta);
                        liston.Add(pedi);liston.Add(entreg);liston.Add(fechet);

                    }
                }
                else
                {
                    mensaje = "detallemany_entrega Not Found";
                }
                conex.Close();
            }
            return mensaje;
        }
    }
}
