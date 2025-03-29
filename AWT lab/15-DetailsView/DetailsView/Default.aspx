<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DetailsView._Default" %>

<!DOCTYPE html>
<html>
<head>
    <title>Employee Details</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Employee Details</h2>

        <asp:TextBox ID="EmployeeIDTextBox" runat="server" placeholder="Enter Employee ID"></asp:TextBox><br /><br />
        <asp:Button ID="GetEmployeeDetailsButton" runat="server" Text="Get Employee Details" OnClick="GetEmployeeDetailsButton_Click" /><br /><br />

        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="True" DataKeyNames="EmployeeID" />
    </form>
</body>
</html>
