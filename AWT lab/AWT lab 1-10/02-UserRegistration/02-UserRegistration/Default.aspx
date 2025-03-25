<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UserRegistration.Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Registration</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 20px; }
        table { width: 50%; }
        .label { font-weight: bold; }
        .btn { background-color: blue; color: white; padding: 5px 10px; }
    </style>
</head>
<body>
    <h1>User Registration Form</h1>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td class="label">User Name:</td>
                <td><asp:TextBox ID="username" runat="server" required="true"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="label">Email ID:</td>
                <td><asp:TextBox ID="EmailID" runat="server" TextMode="Email"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="label">Password:</td>
                <td><asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="label">Confirm Password:</td>
                <td><asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="label">Gender:</td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male"/>
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female"/>
                </td>
            </tr>
            <tr>
                <td class="label">Select Course:</td>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Advanced Java"/>
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Dot Net"/>
                    <asp:CheckBox ID="CheckBox3" runat="server" Text="Mobile Computing"/>
                    <asp:CheckBox ID="CheckBox4" runat="server" Text="Android"/>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Register" CssClass="btn" OnClick="Button1_Click"/>
                </td>
            </tr>
        </table>

        <h2>Registered Details</h2>
        <asp:Label ID="message" runat="server" ForeColor="Red"></asp:Label>
        <table>
            <tr><td class="label">User Name:</td><td><asp:Label ID="ShowUserName" runat="server"></asp:Label></td></tr>
            <tr><td class="label">Email ID:</td><td><asp:Label ID="UserEmailid" runat="server"></asp:Label></td></tr>
            <tr><td class="label">Gender:</td><td><asp:Label ID="ShowGender" runat="server"></asp:Label></td></tr>
            <tr><td class="label">Courses:</td><td><asp:Label ID="ShowCourses" runat="server"></asp:Label></td></tr>
        </table>
    </form>
</body>
</html>
