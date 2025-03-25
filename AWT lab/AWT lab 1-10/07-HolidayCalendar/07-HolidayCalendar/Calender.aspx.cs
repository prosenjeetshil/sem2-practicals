using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _07_HolidayCalendar
{
    public partial class Calender : System.Web.UI.Page
    {
        private Hashtable HolidayList;
        protected void Page_Load(object sender, EventArgs e)
        {
            HolidayList = GetHolidays();

            // Calendar customization
            Calendar1.Caption = "Calendar - Holidays in 2025";
            Calendar1.FirstDayOfWeek = FirstDayOfWeek.Sunday;
            Calendar1.NextPrevFormat = NextPrevFormat.ShortMonth;
            Calendar1.TitleFormat = TitleFormat.Month;
            Calendar1.ShowGridLines = true;
            Calendar1.DayStyle.Height = new Unit(50);
            Calendar1.DayStyle.Width = new Unit(100);
            Calendar1.DayStyle.HorizontalAlign = HorizontalAlign.Center;
            Calendar1.DayStyle.VerticalAlign = VerticalAlign.Middle;
        }

        private Hashtable GetHolidays()
        {
            Hashtable holiday = new Hashtable
            {
                ["1/1/2025"] = "New Year",
                ["1/26/2025"] = "Republic Day",
                ["3/21/2025"] = "Holi",
                ["4/14/2025"] = "Ambedkar Jayanti",
                ["5/1/2025"] = "Labour Day",
                ["8/15/2025"] = "Independence Day",
                ["10/2/2025"] = "Gandhi Jayanti",
                ["10/17/2025"] = "Diwali",
                ["12/25/2025"] = "Christmas"
            };
            return holiday;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            LabelAction.Text = "Selected Date: " + Calendar1.SelectedDate.ToShortDateString();
        }

        // Event for month change
        protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            LabelAction.Text = "Viewing Month: " + e.NewDate.ToString("MMMM yyyy");
        }

        // Event to highlight holidays
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (HolidayList[e.Day.Date.ToShortDateString()] != null)
            {
                e.Cell.BackColor = System.Drawing.Color.LightCoral;
                e.Cell.ForeColor = System.Drawing.Color.White;

                Label label1 = new Label();
                label1.Text = "<br/>" + (string)HolidayList[e.Day.Date.ToShortDateString()];
                label1.Font.Size = new FontUnit(FontSize.Small);
                e.Cell.Controls.Add(label1);
            }
        }
    }
}