using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _13_StudentRecords
{
    public partial class Default : System.Web.UI.Page
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Student (sid, sname, dob, email, address, scourse, admission_date) VALUES (@sid, @sname, @dob, @email, @address, @scourse, @admission_date)", con);
                cmd.Parameters.AddWithValue("@sid", txtID.Text);
                cmd.Parameters.AddWithValue("@sname", txtName.Text);
                cmd.Parameters.AddWithValue("@dob", txtDOB.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@scourse", txtCourse.Text);
                cmd.Parameters.AddWithValue("@admission_date", txtAdmissionDate.Text);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            BindGrid();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Student SET sname=@sname, dob=@dob, email=@email, address=@address, scourse=@scourse, admission_date=@admission_date WHERE sid=@sid", con);
                cmd.Parameters.AddWithValue("@sid", txtID.Text);
                cmd.Parameters.AddWithValue("@sname", txtName.Text);
                cmd.Parameters.AddWithValue("@dob", txtDOB.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@scourse", txtCourse.Text);
                cmd.Parameters.AddWithValue("@admission_date", txtAdmissionDate.Text);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            BindGrid();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE sid=@sid", con);
                cmd.Parameters.AddWithValue("@sid", txtID.Text);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            BindGrid();
        }
    }
}