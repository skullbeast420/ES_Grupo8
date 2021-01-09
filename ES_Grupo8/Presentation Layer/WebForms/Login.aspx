<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Presentation_Layer.WebForms.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<style>
    .topnav {
    width: auto;
    padding: 12px 48px 0;
    margin: auto;
    height: 32px;
    background-color:cornflowerblue;
    color: white;
    }
    
    .auto-style1 {
        width: 1358px;
    }
    .auto-style2 {
        width: 109px;
    }
    
    </style>
</head>
<form id="loginForm" runat="server">
    <section id="main-content">
       <section id="wrapper">
           <div class="row">
               <div class="col-lg-12">
                   <section class="panel">

                       <div class="topnav">
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a class="active">Login</a>
  
                        </div>
                       <div class="panel-body">
                            <table class="auto-style1">
                                <tr>
                                    <td colspan="2">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="2">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">&nbsp;</td>
                                    <td>E-mail:</td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">&nbsp;</td>
                                    <td>
                                        <asp:TextBox ID="TBEmail" runat="server" Width="302px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">&nbsp;</td>
                                    <td>Senha:</td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">&nbsp;</td>
                                    <td>
                                        <asp:TextBox ID="TBSenha" runat="server" Width="302px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">&nbsp;</td>
                                    <td>
                                        <asp:Button ID="BIniciarSessao" runat="server" Onclick="BIniciarSessao_click" Text="Iniciar Sessão" Width="308px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">&nbsp;</td>
                                    <td>Ainda não tem conta?
                                        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/WebForms/CriarConta.aspx" runat="server">Registe-se aqui.</asp:HyperLink>
                                    </td>
                                </tr>
                            </table>
                       </div>

                   </section>
              
           </div>
       </section>
   </section>
</form>



</html>