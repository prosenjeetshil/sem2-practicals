using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DetailsView
{
    public partial class _Default : Page
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["EmployeeDBConnectionString"].ToString();

        protected void GetEmployeeDetailsButton_Click(object sender, EventArgs e)
        {
            int employeeID;
            if (int.TryParse(EmployeeIDTextBox.Text, out employeeID))
            {
                FetchEmployeeDetails(employeeID);
            }
            else
            {
                Response.Write("Invalid Employee ID");
            }
        }

        private void FetchEmployeeDetails(int employeeID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetEmployeeDetails", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable employeeDetails = new DataTable();
                adapter.Fill(employeeDetails);

                if (employeeDetails.Rows.Count > 0)
                {
                    DetailsView1.DataSource = employeeDetails;
                    DetailsView1.DataBind();
                }
                else
                {
                    Response.Write("No employee found with the given ID.");
                }
            }
        }
    }
}
