using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _17_LINQWithDataset
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Get the DataSet with sample data
                DataSet ds = DataSetHelper.GetSampleDataSet();

                // Use LINQ to query the Products table
                var products = from product in ds.Tables["Products"].AsEnumerable()
                               where product.Field<decimal>("Price") > 100 // Filter products with price > 100
                               select new
                               {
                                   ProductID = product.Field<int>("ProductID"),
                                   ProductName = product.Field<string>("ProductName"),
                                   Price = product.Field<decimal>("Price")
                               };

                // Bind the LINQ result to the GridView
                GridView1.DataSource = products.ToList();
                GridView1.DataBind();
            }
        }

        // Optional: Format the price when the row is bound to the GridView
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Format the price column
                e.Row.Cells[2].Text = string.Format("{0:C}", Convert.ToDecimal(e.Row.Cells[2].Text));
            }
        }
    }
}