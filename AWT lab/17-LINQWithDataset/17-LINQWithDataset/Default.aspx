<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_17_LINQWithDataset._Default" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LINQ with DataSet</title>
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
            <!-- GridView Control to Display Products -->
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True" OnRowDataBound="GridView1_RowDataBound">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
