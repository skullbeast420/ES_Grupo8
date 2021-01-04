<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Medicos.aspx.cs" Inherits="Presentation_Layer.WebForms.Medicos" %>

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
<body>
    <form id="form1" runat="server">
        <div id="webform-header-wrapper">
        <div id="webform-header">
            Médicos
        </div>
        <asp:Menu ID="Menu1" runat="server">
            <Items>
                <asp:MenuItem NavigateUrl="~/WebForms/HomePage.aspx" Text="Home Page" Value="Home Page"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/WebForms/MarcarConsulta.aspx" Text="Marcar Consulta" Value="Marcar Consulta"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/WebForms/Agenda.aspx" Text="Agenda" Value="Agenda"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/WebForms/MinhaSaude.aspx" Text="Minha Saúde" Value="Minha Saúde"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/WebForms/Historico.aspx" Text="Histórico" Value="Histórico"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/WebForms/Medicos.aspx" Text="Médicos" Value="Médicos"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/WebForms/Unidades.aspx" Text="Unidades" Value="Unidades"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/WebForms/Especialidades.aspx" Text="Especialidades" Value="Especialidades"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/WebForms/GestaoDeConta.aspx" Text="Gestão de Conta" Value="Gestão de Conta"></asp:MenuItem>
            </Items>
        </asp:Menu>
    </form>
</body>
</html>
