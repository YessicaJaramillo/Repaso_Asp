<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EstadoVariables.aspx.cs" Inherits="Incremento.EstadoVariables" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
        <asp:Button ID="btnIncrementar" runat="server" Text="Incrementar" OnClick="btnIncrementar_Click" />
    </form>
</body>
</html>
