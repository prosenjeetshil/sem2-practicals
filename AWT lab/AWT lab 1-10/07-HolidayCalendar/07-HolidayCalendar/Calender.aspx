<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calender.aspx.cs" Inherits="_07_HolidayCalendar.Calender" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Interactive Calendar with Holidays</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            text-align: center;
            background-color: #f4f4f4;
        }
        .calendar-container {
            width: 50%;
            margin: auto;
            background: white;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0px 0px 10px gray;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="calendar-container">
            <h2>Indian List of Holidays 2025</h2>
            
            <asp:Calendar ID="Calendar1" runat="server" 
                BackColor="#FFFFCC" BorderColor="#FFCC66"
                BorderWidth="1px" DayNameFormat="Shortest"
                Font-Names="Verdana" Font-Size="10pt"
                ForeColor="#663399" ShowGridLines="True"
                OnDayRender="Calendar1_DayRender" 
                OnSelectionChanged="Calendar1_SelectionChanged"
                OnVisibleMonthChanged="Calendar1_VisibleMonthChanged">
                
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" />
                <TitleStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            </asp:Calendar>
            
            <br />
            <asp:Label ID="LabelAction" runat="server" Font-Bold="True"></asp:Label>
        </div>
    </form>
</body>
</html>
