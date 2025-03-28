<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_18_DataBoundControls.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data Binding with GridView</title>
    <style>
        table {
            width: 100%;
            border-collapse: collapse;
        }
        table, th, td {
            border: 1px solid black;
        }
        th, td {
            padding: 8px;
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Data Bound Controls in ASP.NET</h1>
            
            <!-- Add Item Form -->
            <h2>Add a New Item</h2>
            <label for="txtItemName">Item Name:</label>
            <asp:TextBox ID="txtItemName" runat="server" />
            <asp:Button ID="btnAddItem" runat="server" Text="Add Item" OnClick="btnAddItem_Click" />
            <br /><br />
            
            <!-- GridView to display data -->
            <h2>Items List</h2>
            <asp:GridView ID="gvItems" runat="server" AutoGenerateColumns="True" />
        </div>
    </form>
</body>
</html>