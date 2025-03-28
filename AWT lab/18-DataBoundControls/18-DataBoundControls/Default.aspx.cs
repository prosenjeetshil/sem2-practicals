using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _18_DataBoundControls
{
    public partial class Default : Page
    {
        // Simulated data source
        private static List<string> items = new List<string>
        {
            "Apple",
            "Banana",
            "Cherry"
        };

        // Page_Load event handler to bind data to GridView
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        // Method to bind the data source to the GridView
        private void BindGridView()
        {
            gvItems.DataSource = items;
            gvItems.DataBind();
        }

        // Event handler for the "Add Item" button click
        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            string newItem = txtItemName.Text.Trim();
            if (!string.IsNullOrEmpty(newItem))
            {
                // Add new item to the data source
                items.Add(newItem);

                // Clear the input field and rebind the data
                txtItemName.Text = string.Empty;
                BindGridView();
            }
            else
            {
                // Display a simple alert if the input is empty
                Response.Write("<script>alert('Please enter an item name.');</script>");
            }
        }
    }
}