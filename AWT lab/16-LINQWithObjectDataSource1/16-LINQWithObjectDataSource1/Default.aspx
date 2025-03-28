<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_16_LINQWithObjectDataSource1._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LINQ with Object Data Source</title>
    <style>
        table {
            width: 50%;
            border-collapse: collapse;
        }
        th, td {
            padding: 10px;
            border: 1px solid #ddd;
            text-align: center;
        }
        th {
            background-color: #f2f2f2;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Product List</h2>
            
            <!-- ObjectDataSource Control -->
            <asp:ObjectDataSource ID="odsProducts" runat="server"
                TypeName="ProductData"
                SelectMethod="GetProducts" />

            <!-- GridView Control -->
            <asp:GridView ID="GridView1" runat="server"
                AutoGenerateColumns="True"
                DataSourceID="odsProducts"
                OnRowDataBound="GridView1_RowDataBound">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
