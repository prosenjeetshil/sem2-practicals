using System;
using System.Web.UI;

namespace Practical4
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Pass data using Server.Transfer
            Server.Transfer("~/Display.aspx?Name=" + TextBox1.Text + "&Work=Developer");
        }
    }
}
