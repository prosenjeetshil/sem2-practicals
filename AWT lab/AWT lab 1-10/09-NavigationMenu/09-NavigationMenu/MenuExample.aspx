<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuExample.aspx.cs" Inherits="_09_NavigationMenu.MenuExample" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu Example</title>
    <style type="text/css">
        body {
            background-color: mediumaquamarine;
            font-family: Arial;
            font-size: 10pt;
            color: #444;
        }
        .ParentMenu, .ParentMenu:hover {
            width: 100px;
            background-color: #fff;
            color: #333;
            text-align: center;
            height: 30px;
            line-height: 30px;
            margin-right: 5px;
        }
        .ParentMenu:hover {
            background-color: #ccc;
        }
        .ChildMenu, .ChildMenu:hover {
            width: 110px;
            background-color: #fff;
            color: #333;
            text-align: center;
            height: 30px;
            line-height: 30px;
            margin-top: 5px;
        }
        .ChildMenu:hover {
            background-color: #ccc;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
                <LevelMenuItemStyles>
                    <asp:MenuItemStyle CssClass="ParentMenu" />
                    <asp:MenuItemStyle CssClass="ChildMenu" />
                    <asp:MenuItemStyle CssClass="ChildMenu" />
                </LevelMenuItemStyles>
                <StaticSelectedStyle CssClass="selected" />
            </asp:Menu>
        </div>
    </form>
</body>
</html>
