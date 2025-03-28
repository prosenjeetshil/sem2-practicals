using System;
using System.Data;

public class DataSetHelper
{
    // Method to create and return a sample DataSet
    public static DataSet GetSampleDataSet()
    {
        // Create a DataSet
        DataSet dataSet = new DataSet();

        // Create a DataTable for Products
        DataTable productsTable = new DataTable("Products");
        productsTable.Columns.Add("ProductID", typeof(int));
        productsTable.Columns.Add("ProductName", typeof(string));
        productsTable.Columns.Add("Price", typeof(decimal));

        // Add some sample data
        productsTable.Rows.Add(1, "Laptop", 799.99m);
        productsTable.Rows.Add(2, "Smartphone", 499.99m);
        productsTable.Rows.Add(3, "Tablet", 299.99m);
        productsTable.Rows.Add(4, "Headphones", 99.99m);
        productsTable.Rows.Add(5, "Smartwatch", 199.99m);

        // Add table to DataSet
        dataSet.Tables.Add(productsTable);

        return dataSet;
    }
}
