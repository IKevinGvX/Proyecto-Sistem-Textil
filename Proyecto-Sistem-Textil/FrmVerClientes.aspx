<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmVerClientes.aspx.cs" Inherits="Proyecto_Sistem_Textil.FrmVerClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css">
 <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
  <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <title>ViewEmployees</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card-header center"><h1>Consulta De Clientes</h1></div>

         <style>
            div{
                background: linear-gradient(0deg, rgb(255,128,0) 0%, rgb(255,0,0) 100%);

            }
            td{
                background-attachment: fixed;
                background-color: #ffffff;
            }
            th
            {
                background-color: aquamarine
            }
            tr {
                background-color: blue;
            }
        </style>
         <div class="row">
         <div class="col s12 m7">
         <div class="card">
             <aside class="right">
                            <label class="s12 col btn-floating waves-effect blue center">Ingresa Codigo Clientes</label> <br /><br /><br />
                           <asp:TextBox CssClass="waves-effect waves-light btn green center" ID="txtid" runat="server"></asp:TextBox>
                 <br /><br />
                            <asp:Button id="btnenviar" runat="server" Text="Enviar" class="btn btn-primary btn-block fa-lg gradient-custom-2 mb-3" OnClick="BtnEnviar_Click1" />
                 <br />
           <asp:Label CssClass="btn modal-trigger waves-effect waves-light btn right" ID="lblmensaje" runat="server" ForeColor="black"></asp:Label>
                 <br /><br />
             </aside>
            <div class="container">
                <div class="row col s12">
                </div>
            </div>
         <div class="container">            <div class="row"></div>
            <div class="row a12 m12 112">
                <asp:GridView   ID="dgvclientes" runat="server" CellPadding="10" ForeColor="PaleVioletRed" GridLines="None"></asp:GridView>
                </div>
             </div>
             </div>
            </div>
             </div>
                <div class="col s12 m5">
                   <h3 class="center">Opciones</h3>
                 <div class="card-panel teal center">
                   <a  href="FrmVerEmpleados.aspx"class=" center   purple waves-effect waves-light btn-large "><i class="material-icons left">arrow_forward</i>Regresar</a>
                        </div>                     
                    </div>
    </form>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>
</body>
</html>