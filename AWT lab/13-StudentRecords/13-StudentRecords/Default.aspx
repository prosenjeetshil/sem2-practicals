<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_13_StudentRecords.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Registration</title>
    <link href="Stylesheet/StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Student Registration Form</h1>
            <table>
                <tr>
                    <td>Id:</td>
                    <td><asp:TextBox ID="txtID" runat="server" /></td>
                </tr>
                <tr>
                    <td>Name:</td>
                    <td><asp:TextBox ID="txtName" runat="server" /></td>
                </tr>
                <tr>
                    <td>DOB:</td>
                    <td><asp:TextBox ID="txtDOB" runat="server" /></td>
                </tr>
                <tr>
                    <td>Email:</td>
                    <td><asp:TextBox ID="txtEmail" runat="server" /></td>
                </tr>
                <tr>
                    <td>Address:</td>
                    <td><asp:TextBox ID="txtAddress" runat="server" /></td>
                </tr>
                <tr>
                    <td>Course:</td>
                    <td><asp:TextBox ID="txtCourse" runat="server" /></td>
                </tr>
                <tr>
                    <td>Admission Date:</td>
                    <td><asp:TextBox ID="txtAdmissionDate" runat="server" /></td>
                </tr>
            </table>
            <div class="button-group">
                <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            </div>
            <br /><br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" />
        </div>
    </form>
</body>
</html>
