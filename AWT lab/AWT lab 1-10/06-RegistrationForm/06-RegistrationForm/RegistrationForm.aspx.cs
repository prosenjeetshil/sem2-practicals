using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _06_RegistrationForm
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) // Check if all validation passed
            {
                string name = Nametxt.Text;
                string address = Addtxt.Text;
                string password = Passtxt.Text;
                string email = Emailtxt.Text;
                string contactNo = ContNotxt.Text;
                int age = int.Parse(Agetxt.Text);

                // Display success message (or save to database)
                Response.Write("<script>alert('Registration Successful!');</script>");
            }
        }
    }
}

