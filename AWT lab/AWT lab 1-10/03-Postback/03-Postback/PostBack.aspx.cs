using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4
{
    public partial class PostBack : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ControlChange(Object sender, EventArgs e)
        {
            // Get the control name
            string controlName = ((Control)sender).ID;

            // Log the event in the ListBox
            Log(controlName + " Triggered");
        }

        private void Log(string entry)
        {
            listE.Items.Add(entry);
            listE.SelectedIndex = listE.Items.Count - 1;
        }
    }
}
