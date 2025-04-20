<%@ Page Title="Home Page" Language="C#" Async="true"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_28_CalculatorWebClient._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
<asp:TextBox ID="txtResult" runat="server" />



</asp:Content>
