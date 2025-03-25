<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_07_AdRotator.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Random Advertisements</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Ad Rotator</h1>
        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/AdvertisementFile.xml" Width="700px"/>
    </form>
</body>
</html>
