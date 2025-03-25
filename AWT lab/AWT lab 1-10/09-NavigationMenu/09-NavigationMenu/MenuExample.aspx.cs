using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace _09_NavigationMenu
{
    public partial class MenuExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = this.BindMenuData(0);
                DynamicMenuControlPopulation(dt, 0, null);
            }
        }

        protected DataTable BindMenuData(int parentmenuId)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MenuId", typeof(int)));
            dt.Columns.Add(new DataColumn("ParentId", typeof(int)));
            dt.Columns.Add(new DataColumn("Title", typeof(string)));
            dt.Columns.Add(new DataColumn("URL", typeof(string)));

            dt.Rows.Add(1, 0, "Home", "~/Default.aspx");
            dt.Rows.Add(2, 0, "Services", "~/Services.aspx");
            dt.Rows.Add(3, 2, "Consulting", "~/Consult.aspx");

            return dt;
        }

        protected void DynamicMenuControlPopulation(DataTable dt, int parentMenuId, MenuItem parentMenuItem)
        {
            foreach (DataRow row in dt.Select("ParentId=" + parentMenuId))
            {
                MenuItem menuItem = new MenuItem(row["Title"].ToString(), row["MenuId"].ToString(), "", row["URL"].ToString());
                if (parentMenuItem == null)
                    Menu1.Items.Add(menuItem);
                else
                    parentMenuItem.ChildItems.Add(menuItem);
            }
        }
    }
}
