<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBack.aspx.cs" Inherits="Practical4.PostBack" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PostBack Monitoring</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Monitoring PostBack Events:</h1>

            <label>Enter Text:</label>
            <asp:TextBox ID="txt1" runat="server" AutoPostBack="true" OnTextChanged="ControlChange" />
            <br /><br />

            <label>Check Me:</label>
            <asp:CheckBox ID="chk1" runat="server" AutoPostBack="true" OnCheckedChanged="ControlChange" />
            <br /><br />

            <label>Select Option:</label>
            <asp:RadioButton ID="opt11" runat="server" GroupName="Example" AutoPostBack="true" OnCheckedChanged="ControlChange" Text="Option 1" />
            <asp:RadioButton ID="opt21" runat="server" GroupName="Example" AutoPostBack="true" OnCheckedChanged="ControlChange" Text="Option 2" />
            <br /><br />

            <h1>Event Log:</h1>
            <asp:ListBox ID="listE" runat="server" Width="380px" Height="160px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
