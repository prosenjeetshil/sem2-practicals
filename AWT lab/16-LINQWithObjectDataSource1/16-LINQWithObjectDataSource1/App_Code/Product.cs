//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace _16_LINQWithObjectDataSource1.App_Code
//{
//    public class Product
//    {
//    }
//}

// App_Code/Product.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
}

public class ProductData
{
    // Method to get products with LINQ filtering
    public static List<Product> GetProducts()
    {
        var products = new List<Product>
        {
            new Product { ProductID = 1, ProductName = "Laptop", Price = 799.99 },
            new Product { ProductID = 2, ProductName = "Smartphone", Price = 499.99 },
            new Product { ProductID = 3, ProductName = "Tablet", Price = 299.99 },
            new Product { ProductID = 4, ProductName = "Headphones", Price = 99.99 },
            new Product { ProductID = 5, ProductName = "Smartwatch", Price = 199.99 }
        };

        // LINQ query to filter products with price > 100
        var filteredProducts = from product in products
                               where product.Price > 100
                               select product;

        return filteredProducts.ToList();
    }
}
