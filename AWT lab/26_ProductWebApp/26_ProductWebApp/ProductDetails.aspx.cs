using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _26_ProductWebApp.ProductService;
using System.Xml;
using System.Xml.Linq;

namespace _26_ProductWebApp
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnFetchProduct_Click(object sender, EventArgs e)
        {
            int productId;
            if (!int.TryParse(txtProductId.Text, out productId))
            {
                // Show error or return
                return;
            }

            // Replace "localhost" with your actual service namespace
            var service = new ProductService.ProductServiceSoapClient();
            XElement productXml = service.GetProductDetails(productId);
            DataSet ds = new DataSet();
            using (var reader = productXml.CreateReader())
            {
                ds.ReadXml(reader);
                gvProductDetails.DataSource = ds;
                gvProductDetails.DataBind();
            }

        }
    }
}