<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebAppActualizar.aspx.cs" Inherits="Webparcial.WebAppActualizar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 543px">
    
        <asp:Label ID="lblcedula" runat="server" Text="CEDULA"></asp:Label>
        <asp:TextBox ID="txtcedula" runat="server" style="margin-left: 139px" Width="180px"></asp:TextBox>
        <asp:Button ID="btnbuscar" runat="server" OnClick="btnbuscar_Click" style="margin-left: 115px" Text="BUSCAR" Width="98px" />
        <asp:GridView ID="TABLA" runat="server">
        </asp:GridView>
        <asp:Label ID="lblcedula1" runat="server" Text="CEDULA"></asp:Label>
        <asp:TextBox ID="tcedula" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Lblnombre" runat="server" Text="NOMBRE"></asp:Label>
        <asp:TextBox ID="tnombre" runat="server" Height="22px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblapellido" runat="server" Text="APELLIDO"></asp:Label>
        <asp:TextBox ID="tapellido" runat="server"></asp:TextBox>
        <br />
        <br />
        E-MAIL<asp:TextBox ID="tcorreo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbldomicilio" runat="server" Text="DOMICILIO"></asp:Label>
        <asp:TextBox ID="tdomicilio" runat="server"></asp:TextBox>
        <asp:Button ID="btnactualizar" runat="server" OnClick="btnactualizar_Click" style="margin-left: 60px" Text="ACTUALIZAR" Width="165px" />
        <br />
        <br />
        <asp:Label ID="lblciudad" runat="server" Text="CIUDAD"></asp:Label>
        <asp:TextBox ID="tciudad" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbltelefono" runat="server" Text="TELEFONO"></asp:Label>
        <asp:TextBox ID="ttelefono" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
