<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CargarImagen.aspx.cs" Inherits="DesarrolloWebLab5.CargarImagen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:FileUpload ID="fuArchivo" runat="server" />
        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
        <p>
            <asp:Image ID="imgFoto" runat="server" />
        </p>
        <asp:TextBox ID="txtSalida" runat="server" Height="200px" TextMode="MultiLine" Width="360px"></asp:TextBox>
    </form>
</body>
</html>
