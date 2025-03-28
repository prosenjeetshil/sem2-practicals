using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _16_LINQWithObjectDataSource1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // No specific logic needed for this demo.
        }

        // RowDataBound event to format price column
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Format the price column with currency format
                e.Row.Cells[2].Text = string.Format("{0:C}", Convert.ToDouble(e.Row.Cells[2].Text));
            }
        }
    }
}