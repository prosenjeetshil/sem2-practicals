<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Data</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- GridView to display employee data -->
            <asp:GridView ID="GridView1" runat="server" 
                BackColor="White" BorderColor="#CC9966" BorderStyle="None" 
                BorderWidth="1px" CellPadding="4">
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            </asp:GridView>
            <br />
            <!-- Button to connect and fetch data -->
            <asp:Button ID="Connected" runat="server" OnClick="Connected_Click" Text="Connected" />
            <!-- Button to disconnect and fetch data -->
            <asp:Button ID="Disconnected" runat="server" OnClick="Disconnected_Click" Text="Disconnected" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                SelectCommand="SELECT * FROM [employee]" />
        </div>
    </form>
</body>
</html>


