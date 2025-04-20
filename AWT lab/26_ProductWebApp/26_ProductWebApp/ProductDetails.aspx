<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="_26_ProductWebApp.ProductDetails" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Details</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Product Details</h2>
            <asp:Label ID="lblProductDetails" runat="server" Text="Enter Product ID:" />
            <asp:TextBox ID="txtProductId" runat="server" />
            <asp:Button ID="btnFetchProduct" runat="server" Text="Fetch Product" OnClick="btnFetchProduct_Click" />
            <br /><br />
            <asp:GridView ID="gvProductDetails" runat="server" AutoGenerateColumns="True" />
        </div>
    </form>
</body>
</html>