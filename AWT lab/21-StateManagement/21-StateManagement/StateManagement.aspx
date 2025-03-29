<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StateManagement.aspx.cs" Inherits="_21_StateManagement.StateManagement" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Client-Side State Management</title>
    <style>
        label {
            font-weight: bold;
            display: block;
            margin-top: 10px;
        }
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }
        h1, h2 {
            color: #0078D7;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Client-Side State Management with ViewState and Cookies</h1>

            <!-- ViewState Section -->
            <h2>Store Name using ViewState</h2>
            <label for="txtNameViewState">Enter your name:</label>
            <asp:TextBox ID="txtNameViewState" runat="server"></asp:TextBox>
            <asp:Button ID="btnSaveViewState" runat="server" Text="Save to ViewState" OnClick="btnSaveViewState_Click" />
            <br /><br />
            <asp:Label ID="lblViewState" runat="server" Text="Your name from ViewState will appear here."></asp:Label>
            <br /><br />

            <!-- Cookies Section -->
            <h2>Store Name using Cookies</h2>
            <label for="txtNameCookie">Enter your name:</label>
            <asp:TextBox ID="txtNameCookie" runat="server"></asp:TextBox>
            <asp:Button ID="btnSaveCookie" runat="server" Text="Save to Cookie" OnClick="btnSaveCookie_Click" />
            <br /><br />
            <asp:Label ID="lblCookie" runat="server" Text="Your name from Cookies will appear here."></asp:Label>
        </div>
    </form>
</body>
</html>
