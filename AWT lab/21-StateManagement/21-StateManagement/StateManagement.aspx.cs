using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _21_StateManagement
{
    public partial class StateManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if ViewState contains a stored name and display it
            if (ViewState["NameFromViewState"] != null)
            {
                lblViewState.Text = "Your name from ViewState: " + ViewState["NameFromViewState"].ToString();
            }

            // Check if Cookies contain a stored name and display it
            if (Request.Cookies["NameFromCookie"] != null)
            {
                lblCookie.Text = "Your name from Cookie: " + Request.Cookies["NameFromCookie"].Value;
            }
        }

        // Save name to ViewState
        protected void btnSaveViewState_Click(object sender, EventArgs e)
        {
            string nameFromViewState = txtNameViewState.Text;
            ViewState["NameFromViewState"] = nameFromViewState;
            lblViewState.Text = "Your name has been saved to ViewState: " + nameFromViewState;
        }

        // Save name to Cookie
        protected void btnSaveCookie_Click(object sender, EventArgs e)
        {
            string nameFromCookie = txtNameCookie.Text;
            HttpCookie cookie = new HttpCookie("NameFromCookie", nameFromCookie)
            {
                Expires = DateTime.Now.AddDays(1) // Cookie will expire in 1 day
            };
            Response.Cookies.Add(cookie);
            lblCookie.Text = "Your name has been saved to Cookie: " + nameFromCookie;
        }
    }
}