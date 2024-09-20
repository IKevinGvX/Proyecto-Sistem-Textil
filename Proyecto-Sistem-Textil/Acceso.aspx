<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Acceso.aspx.cs" Inherits="Proyecto_Sistem_Textil.Acceso" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <link rel="stylesheet" type="text/css" href="style.css">
 <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous">
    <title>Loggin</title>
</head>
<body>
    <div class="container">
        <div class="d-flex justify-content-center h-100">  
            <div class="card">               
                <div class="card-header">
                    <h3>Sign In</h3>
                    <div class="d-flex justify-content-end social_icon">
                        <a href="https://www.facebook.com/" target="_blank">
                            <span><i class="fab fa-facebook-square"></i></span>
                        </a>    
                        <a href="https://www.google.com/" target="_blank">
                            <span><i class="fab fa-google-plus-square"></i></span>
                        </a>  
                        <a href="https://x.com/i/flow/login" target="_blank">
                            <span><i class="fab fa-twitter-square"></i></span>
                        </a>                
                    </div>
                </div>
                <div class="card-body">
                    <form id="form1" runat="server">
                        <div class="input-group form-group">
                            <div class="input-group-prepend">
                                <span class="input-group-text"><i class="fas fa-user"></i></span>
                            </div>
                            <asp:TextBox id="txtnombre"  runat="server" Width="300px" Height="35px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvnombre" runat="server" ControlToValidate="txtnombre"
                                ErrorMessage="Debe Ingresar Nombre Completo"  ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                        <div class="input-group form-group">
                            <div class="input-group-prepend">
                                <span class="input-group-text"><i class="fas fa-key"></i></span>
                            </div>
                            <asp:TextBox id="txtDNI"  runat="server" TextMode="Password" Width="300px" Height="35px" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvpassword" runat="server" ControlToValidate="txtDNI"
                                ErrorMessage="Debe Ingresar DNI Correcta" ForeColor ="Red"></asp:RequiredFieldValidator>
                        </div>
                        <br />
                        <div class="text-center pt-1 mb-5 pb-1">
                            <asp:Button id="btnenviar" runat="server" Text="Enviar" class="btn btn-primary btn-block fa-lg gradient-custom-2 mb-3" OnClick="BtnEnviar_Click1" />
                        </div>
                        <asp:Label id="lblmensaje" runat="server" Font-Bold ="true" Font-Size="15pt" ForeColor ="RosyBrown"></asp:Label>
                    </form>
                </div>
                <div class="card-footer">
                    <div class="d-flex justify-content-center links">
                        No Tienes Cuenta?<a href="%">Registrate Aqui</a>
                    </div>
                </div>
                <div class="animate-bounce ...">
                    <div class="alert alert-danger" role="alert">
                        <i class="fas fa-arrow-down fa-lg">Recuerda, No Compartas Tu Informacion!</i>
                    </div>
                </div>
     <script src="https://code.jquery.com/jquery-3.7.1.min.js" type="text/javascript"></script> 
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script type="text/javascript" src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.6/js/materialize.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>
</body>
</html>
