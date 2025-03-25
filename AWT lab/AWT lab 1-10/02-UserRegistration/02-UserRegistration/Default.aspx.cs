using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserRegistration
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            message.Text = "Hello " + username.Text + " ! ";
            message.Text += "<br/>You have successfully registered with the following details.";

            ShowUserName.Text = username.Text;
            UserEmailid.Text = EmailID.Text;

            // Gender Selection
            ShowGender.Text = RadioButton1.Checked ? RadioButton1.Text : RadioButton2.Text;

            // Courses Selection
            string courses = "";
            if (CheckBox1.Checked) { courses += CheckBox1.Text + " "; }
            if (CheckBox2.Checked) { courses += CheckBox2.Text + " "; }
            if (CheckBox3.Checked) { courses += CheckBox3.Text + " "; }
            if (CheckBox4.Checked) { courses += CheckBox4.Text; }

            ShowCourses.Text = courses;

            // Clear input fields after submission
            username.Text = "";
            EmailID.Text = "";
            Password.Text = "";
            ConfirmPassword.Text = "";
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;

            // Show alert message
            Response.Write("<script>alert('Registered successfully!');</script>");
        }
    }
}
