using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _12_ConnectDisconnectDatabase
{
    public partial class Disconnect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            gvEmp.Visible = true;
            createnewrow();
        }

        public void createnewrow()
        {
            DataTable mytable = new DataTable();

            if (ViewState["Row"] != null)
            {
                mytable = (DataTable)ViewState["Row"];
                DataRow dr = mytable.NewRow();
                dr["EmpID"] = Convert.ToInt32(txt_id.Text);
                dr["EmpName"] = txt_name.Text;
                dr["EmpDesignation"] = txt_Designation.Text;
                dr["EmpContact"] = Convert.ToInt32(txt_contact.Text);
                dr["EmpAddress"] = txt_Address.Text;
                mytable.Rows.Add(dr);
            }
            else
            {
                mytable.Columns.Add("EmpID", typeof(int));
                mytable.Columns.Add("EmpName", typeof(string));
                mytable.Columns.Add("EmpDesignation", typeof(string));
                mytable.Columns.Add("EmpContact", typeof(int));
                mytable.Columns.Add("EmpAddress", typeof(string));

                DataRow dr = mytable.NewRow();
                dr["EmpID"] = Convert.ToInt32(txt_id.Text);
                dr["EmpName"] = txt_name.Text;
                dr["EmpDesignation"] = txt_Designation.Text;
                dr["EmpContact"] = Convert.ToInt32(txt_contact.Text);
                dr["EmpAddress"] = txt_Address.Text;
                mytable.Rows.Add(dr);
            }

            ViewState["Row"] = mytable;
            gvEmp.DataSource = ViewState["Row"];
            gvEmp.DataBind();
        }
    }
}