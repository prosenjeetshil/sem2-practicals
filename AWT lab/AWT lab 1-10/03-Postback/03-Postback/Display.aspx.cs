using System;
using System.Web.UI;

namespace Practical4
{
    public partial class Display : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                // Retrieve values from Query String
                string name = Request.QueryString["Name"];
                string work = Request.QueryString["Work"];

                // Display Data
                Label1.Text = "Welcome " + name + " : .Net " + work;
            }
        }
    }
}
