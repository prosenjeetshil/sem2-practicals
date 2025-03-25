<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AutoPostBack.aspx.cs" Inherits="Project4New.AutoPostBack" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AutoPostBack Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Select a Course:</h2>

            <asp:Label runat="server" Text="Prosenjeet Shil 125"></asp:Label>
            <br /><br />

            <asp:DropDownList ID="Course" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Text="MCA" Value="1"></asp:ListItem>
                <asp:ListItem Text="BCA" Value="2"></asp:ListItem>
                <asp:ListItem Text="BSCIT" Value="3"></asp:ListItem>
                <asp:ListItem Text="BSCCS" Value="4"></asp:ListItem>
                <asp:ListItem Text="MSCIT" Value="5"></asp:ListItem>
            </asp:DropDownList>

        </div>
    </form>
</body>
</html>
