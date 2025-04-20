using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace _26_ProductWebService
{
    [WebService(Namespace = "http://www.example.com/ProductService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class ProductService : WebService
    {
        [WebMethod]
        public XmlNode GetProductDetails(int productId)
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlElement root = xmlDoc.CreateElement("ProductDetails");
            xmlDoc.AppendChild(root);

            XmlElement product = xmlDoc.CreateElement("Product");
            root.AppendChild(product);

            XmlElement id = xmlDoc.CreateElement("ProductId");
            id.InnerText = productId.ToString();
            product.AppendChild(id);

            XmlElement name = xmlDoc.CreateElement("ProductName");
            name.InnerText = "Product " + productId;
            product.AppendChild(name);

            XmlElement price = xmlDoc.CreateElement("Price");
            price.InnerText = "$" + (productId * 10);
            product.AppendChild(price);

            return xmlDoc.DocumentElement; // ✅ Return type is XmlNode
        }

    }
}
