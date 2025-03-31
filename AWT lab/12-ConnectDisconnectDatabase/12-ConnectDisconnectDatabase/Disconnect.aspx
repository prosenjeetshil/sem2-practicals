<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Disconnect.aspx.cs" Inherits="_12_ConnectDisconnectDatabase.Disconnect" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Disconnected Architecture</title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>ID:</td>
                <td><asp:TextBox ID="txt_id" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Name:</td>
                <td><asp:TextBox ID="txt_name" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Designation:</td>
                <td><asp:TextBox ID="txt_Designation" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Contact:</td>
                <td><asp:TextBox ID="txt_contact" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Address:</td>
                <td><asp:TextBox ID="txt_Address" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="Button1" runat="server" Text="Show" OnClick="Button1_Click" /></td>
            </tr>
        </table>
        <div>
            <asp:GridView ID="gvEmp" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
