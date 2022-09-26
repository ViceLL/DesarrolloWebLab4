<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="DesarrolloWebLab5.Cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtCookie" runat="server" Width="293px"></asp:TextBox>
        </div>
        <asp:Button ID="btnLeerCookies" runat="server" OnClick="btnLeerCookies_Click" Text="Leer Cookies" />
        <asp:Button ID="btnCrearCookies" runat="server" OnClick="btnCrearCookies_Click" Text="Crear Cookies" />
        <p>
            <asp:Label ID="lblCookie" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
