<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarcarConsulta.aspx.cs" Inherits="Presentation_Layer.WebForms.Marcar_Consulta" %>

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
            Marcar Consulta
        </div>

        <h2>Marcação Online</h2>
            
            <br />Marcação para:<br />
            <asp:DropDownList ID="DDLPessoa" runat="server" Height="19px" Width="320px">
                <asp:ListItem Value="">Para quem é a marcação?</asp:ListItem>
            </asp:DropDownList>
            
            <br />

            Unidade de Saúde<br />
            <asp:DropDownList ID="DDLUnidade" runat="server" Height="16px" Width="320px">
                <asp:ListItem Value="">Escolha uma unidade de saúde</asp:ListItem>
            </asp:DropDownList>
            <br />
            Especialidade:<br />
            <asp:DropDownList ID="DDLEspecialidade" runat="server" Height="18px" Width="320px">
                <asp:ListItem Value="">Escolha uma especialidade</asp:ListItem>
            </asp:DropDownList>
            <br />
            Profissional de Saúde (opcional):<br />
            <asp:DropDownList ID="DDLProfissional" runat="server" Height="16px" Width="320px">
                <asp:ListItem Value="">Escolha um profissional de saúde</asp:ListItem>
            </asp:DropDownList>
            <br />
            Para quando pretende marcar?<br />
            <asp:Calendar ID="Calendario" runat="server"></asp:Calendar>
            <br />
            Seguros e outros regimes:<br />
            <asp:DropDownList ID="DDLSeguro" runat="server" Height="18px" Width="320px">
                <asp:ListItem Value="">Escolha uma opção</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="35px" Text="Marcar Consulta" Width="320px" />
            <br />
            <br />
            <br />
            <br />
            
    </form>
</body>
</html>
