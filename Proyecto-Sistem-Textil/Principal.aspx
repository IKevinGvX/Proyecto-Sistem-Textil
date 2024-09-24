<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Proyecto_Sistem_Textil.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css">
 <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
<title>Inicio Session</title>
</head>
<body>
    <form id="form1" runat="server">
               <nav>
            <div class="nav-wrapper red lighten #bf360c deep-orange darken-4    ">
                <a  class="brand-logo "><i class="material-icons pulse purple">cloud</i> Industrias Textiles Sallco</a>
                <h2 class="brand-logo pulse purple center ">Bienvenido Usuario : </h2>
                <ul class="right hide-on-med-and-down">
                    <li><a id="search"><i class="material-icons">search</i></a></li>
                    <li><a href="test.asmx" id="view_module"><i class="material-icons">view_module</i></a></li>
                    <li><a id="load"><i class="material-icons">refresh</i></a></li>                    
                    <li><a id="morevert"><i class="material-icons">more_vert</i></a></li>

                </ul>

            </div>
        </nav>
  <div class="container">
            <style>
                div{
                    background: linear-gradient(0deg, rgb(255,128,0) 0%, rgb(255,0,0) 100%);

                }
            </style>
      <div class=" container">
            <div class="row"></div>
            <div class="row a12 m12 112">
                <div class="row">
                    <div class="col s12 m6">
                        <div class="card">
                            <div class="card-image">
                                <img src="Photos/usuario.png">
                                <span class="card-title red pulse" >Formulario De Usuarios</span>
                                <a href="FrmVerEmpleados.aspx" class="btn-floating btn-large pulse right"><i class="material-icons">add_circle</i></a>
                            </div>
                            <div class="card-content">
                                <p class="brown">Conoce Usuarios (Empleados) Que Estan Registrados</p>
                            </div>
                        </div>
                    </div>
                    <div class="col s12 m6">
                        <div class="card">
                            <div class="card-image">
                                <img src="Photos/almacen.png">
                                <span class="card-title purple pulse">Formulario De Almacen</span>
                                <a href="FrmVerAlmacen.aspx" class="btn-floating btn-large pulse right"><i class="material-icons">add_circle</i></a>
                            </div>
                            <div class="card-content">
                                <p class="blue">Conoce El Ingresa Y Salida De Tus Productos</p>
                            </div>
                        </div>
                    </div>
                    <div class="col s12 m6">
                        <div class="card">
                            <div class="card-image">
                                <img src="Photos/productos.png">
                                <span class="card-title red pulse">Formulario De Productos</span>
                                <a  href="Producto.aspx" class="btn-floating btn-large pulse right"><i class="material-icons">add_circle</i></a>
                            </div>
                            <div class="card-content">
                                <p class="brown">Realiza Registros De Producto Ingresa Aqui.</p>
                            </div>
                        </div>
                    </div>
                    <div class="col s12 m6">
                        <div class="card center">
                            <div class="card-image center">
                                <img src="Photos/inventario.png">
                                <span class="card-title purple pulse">Formulario De Inventario</span>
                                <a  href="FrmDetalle_Pedidos.aspx" class="btn-floating btn-large pulse right"><i class="material-icons">add_circle</i></a>
                            </div>
                            <div class="card-content">
                                <p class="blue">Gestiona El Inventario, Principal Del Ingreso de Productos</p>
                            </div>
                        </div>
                    </div>
                </div>
                    <div class="nav-content">
       <h4 class="center">INGRESAR API SWAGGER</h4>
      <ul class="tabs tabs-transparent center">
      <asp:Button  ID="Button4" runat="server" CssClass="btn" Text="Proveedores" />
      <asp:Button ID="Button3" runat="server" CssClass="btn" Text="Almacen" />
      <asp:Button ID="Button1" runat="server" CssClass="btn" Text="Clientes" />
      <asp:Button ID="Button2" runat="server" CssClass="btn" Text="Empleados" />
      <asp:Button ID="Button5" runat="server" CssClass="btn" Text="Salida Inventario" />
      <asp:Button ID="Button6" runat="server" CssClass="btn" Text="Entrega Inventario" />
      <asp:Button ID="Button7" runat="server" CssClass="btn" Text="Detalle Pedido Cliente   " />
      <asp:Button ID="vistaproductop" runat="server" CssClass="btn" Text="Productos" />
      </ul> 
    </div>
    </div>
        </div>
      <div class="fixed-action-btn">
  <a class="btn-floating btn-large red">
    <i class="large material-icons">mode_edit</i>
  </a>
  <ul>
    <li><a href ="Proveedores.aspx" class="btn-floating red"><i class="material-icons">lightbulb_outline</i></a></li>
    <li><a href ="FrmVerClientes.aspx"  class="btn-floating yellow darken-1"><i class="material-icons">group</i></a></li>
    <li><a href ="Producto.aspx"  class="btn-floating green"><i class="material-icons">hot_tub</i></a></li>
    <li><a href ="FrmVerEmpleados.aspx"  class="btn-floating green"><i class="material-icons">report</i></a></li>
    <li><a href ="FrmVerAlmacen.aspx"  class="btn-floating blue"><i class="material-icons">tablet</i></a></li>
  </ul>
</div>
      </div>
        <script>
            document.getElementById('load').addEventListener('click', function () {
                // Aquí puedes poner la lógica que deseas ejecutar al hacer clic en el botón
                location.reload(); // Esto recarga la página
            });
        </script>
        <footer class="page-footer red lighten #bf360c deep-orange darken-4">
            <div class="footer-copyright #bf360c deep-orange darken-4">
                <div class="container">
                    @ 2024 Todos Los Derechos Reservados por  Industrias Textiles Sallco E.I.R.L.
                </div>
            </div>
        </footer>
  </form>
<script>
    document.addEventListener('DOMContentLoaded', function () {
        var elems = document.querySelectorAll('.fixed-action-btn');
        var instances = M.FloatingActionButton.init(elems);
    });
</script>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
       <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>

</body>
</html>
