<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Presentation_Layer.WebForms.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<style>
    #webform-header {
    width: auto;
    padding: 12px 48px 0;
    margin: auto;
    height: 32px;
    background-color:rgb(0, 148, 255);
    color: white;
    }
</style>
</head>
<form id="form1" runat="server">
    <div id="webform-header-wrapper">
        <div id="webform-header">
            Iniciar Sessão
        </div>
    </div>
    <br />
    <br />
        E-mail:
    <br />
    <asp:TextBox ID="TBEmail" runat="server" Width="320px"></asp:TextBox>
    <br />
        Password:
    <br />
    <asp:TextBox ID="TBSenha" runat="server" Width="320px"></asp:TextBox>
    <br />
    <p>
        <asp:Button ID="BIniciarSessao" runat="server" OnClick="BIniciarSessao_click" Text="Iniciar Sessão" Width="326px" />
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text=" Não tem conta? "></asp:Label>
        <asp:HyperLink ID="LinkCriarConta" runat="server" NavigateUrl="~/WebForms/CriarConta.aspx">Criar Conta</asp:HyperLink>
    </p>
</form>


</html>