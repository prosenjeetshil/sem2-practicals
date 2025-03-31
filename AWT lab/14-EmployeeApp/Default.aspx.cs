using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string StrSQL = "SELECT * FROM employee";
    string StrConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EmployeeDB.mdf;Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    // Connected Mode
    protected void Connected_Click(object sender, EventArgs e)
    {
        SqlConnection objConn = new SqlConnection(StrConnection);
        SqlCommand objCmd = new SqlCommand(StrSQL, objConn);
        objCmd.CommandType = CommandType.Text;

        try
        {
            objConn.Open();
            SqlDataReader objDr = objCmd.ExecuteReader();
            GridView1.DataSource = objDr;
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write("Error: " + ex.Message);
        }
        finally
        {
            objConn.Close();
        }
    }

    // Disconnected Mode
    protected void Disconnected_Click(object sender, EventArgs e)
    {
        SqlDataAdapter objDa = new SqlDataAdapter();
        DataSet objDs = new DataSet();
        SqlConnection objConn = new SqlConnection(StrConnection);
        SqlCommand objCmd = new SqlCommand(StrSQL, objConn);
        objCmd.CommandType = CommandType.Text;
        objDa.SelectCommand = objCmd;

        try
        {
            objDa.Fill(objDs, "employee");
            GridView1.DataSource = objDs.Tables[0];
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write("Error: " + ex.Message);
        }
    }
}
