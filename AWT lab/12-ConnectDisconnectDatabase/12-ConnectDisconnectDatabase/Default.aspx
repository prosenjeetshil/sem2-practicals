<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_12_ConnectDisconnectDatabase.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Connected Architecture</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Emp" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Emp" HeaderText="Emp" ReadOnly="True" SortExpression="Emp" />
                    <asp:BoundField DataField="EmpName" HeaderText="Emp Name" SortExpression="EmpName" />
                    <asp:BoundField DataField="EmpDesignation" HeaderText="Designation" SortExpression="EmpDesignation" />
                    <asp:BoundField DataField="EmpContact" HeaderText="Contact" SortExpression="EmpContact" />
                    <asp:BoundField DataField="EmpAddress" HeaderText="Address" SortExpression="EmpAddress" />
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                SelectCommand="SELECT * FROM Employee">
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
