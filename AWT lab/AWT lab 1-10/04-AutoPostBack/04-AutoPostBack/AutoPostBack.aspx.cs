using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project4New
{
    public partial class AutoPostBack : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get selected item text and value
            string message = Course.SelectedItem.Text + " - " + Course.SelectedItem.Value;

            // Show JavaScript alert with the selected value
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + message + "');", true);
        }
    }
}
