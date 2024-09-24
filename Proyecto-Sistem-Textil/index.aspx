﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Proyecto_Sistem_Textil.Acceso" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>LogginTextil</title>
    <link rel="stylesheet" href="estilo.css">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css" rel="stylesheet">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous">

</head>
<body>
    <div id="logo"> 
        <h1><i> Welcome Services Web Sallco Textil</i></h1>
      </div> 
      <section class="stark-login">
        <form class= "login-card" runat="server">	
          <div id="login-card button"> 
            <div id="fade-box">
            <asp:TextBox id="txtnombre"  Text="Ingresa Tu Nombre" runat="server" Width="300px" Height="35px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvnombre" runat="server" ControlToValidate="txtnombre"
                ErrorMessage="Debe Ingresar Nombre Completo"  ForeColor="Red"></asp:RequiredFieldValidator>
              </div>
            <div id="fade-box">
            <asp:TextBox id="txtDNI"  TextMode="Password" runat="server" Width="300px" Height="35px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvpassword" runat="server" ControlToValidate="txtDNI"
                ErrorMessage="Debe Ingresar DNI Correcta" ForeColor ="Red"></asp:RequiredFieldValidator>
             <div id="fade-box">
            <asp:Button id="Button1" runat="server" Text="Enviar"  CssClass="login-card button" Width="300px" Height="35px" OnClick="BtnEnviar_Click1" /> 
           <asp:Label id="lblmensaje" runat="server" Font-Bold ="true" CssClass="login-card button" Font-Size="15pt" ForeColor ="RosyBrown"></asp:Label>
                 </div>
                </div>
            </form>
            <div class="hexagons">
              <span>&#x2B22;</span>
              <span>&#x2B22;</span>
              <span>&#x2B22;</span>
              <span>&#x2B22;</span>
              <span>&#x2B22;</span>
              <span>&#x2B22;</span>
              <span>&#x2B22;</span>
              <span>&#x2B22;</span>
              <span>&#x2B22;</span>
              <span>&#x2B22;</span>
              <span>&#x2B22;</span>
              <span>&#x2B22;</span>
              <br>
                <span>&#x2B22;</span>
                <span>&#x2B22;</span>
                <span>&#x2B22;</span>
                <span>&#x2B22;</span>
                <span>&#x2B22;</span>
                <span>&#x2B22;</span>
                <span>&#x2B22;</span>
                <span>&#x2B22;</span>
                <span>&#x2B22;</span>
                <span>&#x2B22;</span>
                <span>&#x2B22;</span>
                <br>
                  <span>&#x2B22;</span>
                  <span>&#x2B22;</span>
                  <span>&#x2B22;</span>
                  <span>&#x2B22;</span> 
                  <span>&#x2B22;</span>
                  <span>&#x2B22;</span>
                  <span>&#x2B22;</span>
                  <span>&#x2B22;</span>
                  <span>&#x2B22;</span>
                  <span>&#x2B22;</span>
                  <span>&#x2B22;</span>
                  <span>&#x2B22;</span>
                  
                  <br>
                    <span>&#x2B22;</span>
                    <span>&#x2B22;</span>
                    <span>&#x2B22;</span>
                    <span>&#x2B22;</span>
                    <span>&#x2B22;</span>
                    <span>&#x2B22;</span>
                    <span>&#x2B22;</span>
                    <span>&#x2B22;</span>
                    <span>&#x2B22;</span>
                    <span>&#x2B22;</span>
                    <span>&#x2B22;</span>
                    <br>
                      <span>&#x2B22;</span>
                      <span>&#x2B22;</span>
                      <span>&#x2B22;</span>
                      <span>&#x2B22;</span>
                      <span>&#x2B22;</span>
                      <span>&#x2B22;</span>
                      <span>&#x2B22;</span>
                      <span>&#x2B22;</span>
                      <span>&#x2B22;</span>
                      <span>&#x2B22;</span>
                      <span>&#x2B22;</span>
                      <span>&#x2B22;</span>
                    </div>      
                  </section> 
                  
                  <div id="circle1">
                    <div id="inner-cirlce1">
                      <h2> </h2>
                    </div>
                  </div>
    <br /><br />
               <section class ="fade">
                <div class="d-flex justify-content-end social_icon">
                  <a href="https://www.facebook.com/" target="_blank">
                      <span><i class="fab fa-facebook-square fa-2x"></i></span>
                  </a>    
                  <a href="https://www.google.com/" target="_blank">
                      <span><i class="fab fa-google-plus-square fa-2x"></i></span>
                  </a>  
                  <a href="https://x.com/i/flow/login" target="_blank">
                      <span><i class="fab fa-twitter-square fa-2x"></i></span>
                  </a>
              </div>
               </section>                   
</body>
</html>