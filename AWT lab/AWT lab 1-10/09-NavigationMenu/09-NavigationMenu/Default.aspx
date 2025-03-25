<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_09_NavigationMenu.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Navigation Menu</h1>
            <asp:TreeView ID="TreeView1" runat="server" ImageSet="Simple" NodeIndent="10" DataSourceID="SiteMapDataSource1">
                <HoverNodeStyle Font-Underline="True" ForeColor="#DD5555" />
                <NodeStyle Font-Names="Verdana" Font-Size="12pt" ForeColor="Black" HorizontalPadding="0px" NodeSpacing="0px" VerticalPadding="5px"></NodeStyle>
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" ForeColor="#DD5555" />
            </asp:TreeView>
            <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="false" />
        </div>
    </form>
</body>
</html>
