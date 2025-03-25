<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_10_FileUploadApp.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>File Upload App</title>
</head>
<body>
    <form id="uploadForm" runat="server">
        <div style="text-align:center;">
            <h2>📂 File Upload and Download</h2>
            <p>Choose a file to upload:</p>

            <asp:FileUpload ID="FileUpload" runat="server" />
            <br /><br />

            <asp:Button ID="btnUpload" runat="server" Text="Upload File" OnClick="btnUpload_Click" />
            <br /><br />

            <asp:Label ID="lblUploadStatus" runat="server" ForeColor="Green"></asp:Label>
            <br /><br />

            <asp:Label ID="lblFileName" runat="server"></asp:Label>
            &nbsp;&nbsp;
            <asp:Button ID="btnDownload" runat="server" Text="Download File" OnClick="btnDownload_Click" Visible="false"/>
            <br /><br />

            <asp:Label ID="lblDownloadStatus" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
