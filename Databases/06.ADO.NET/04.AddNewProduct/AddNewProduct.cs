namespace AddNewProduct
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class AddNewProduct
    {
        // 04.Write a method that adds a new product in the products table in the Northwind 
        //    database. Use a parameterized SQL command.

        static void Main()
        {
            string productName = "Lukanka";
            string supplierId = "7";
            string categoryId = "3";
            string quantityPerUnit = "200g";
            string unitPrice = "50";

            SqlConnection dbCon = new SqlConnection("Server=.; " +
            "Database=Northwind; Integrated Security=true");

            SqlCommand cmdInsertProduct = new SqlCommand(
            "INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice) " +
            "VALUES (@name, @supplierid, @categoryid, @qualityperunit, @unitprice)", dbCon);

            cmdInsertProduct.Parameters.AddWithValue("@name", productName);
            cmdInsertProduct.Parameters.AddWithValue("@supplierid", supplierId);
            cmdInsertProduct.Parameters.AddWithValue("@categoryid", categoryId);
            cmdInsertProduct.Parameters.AddWithValue("@qualityperunit", quantityPerUnit);
            cmdInsertProduct.Parameters.AddWithValue("@unitprice", unitPrice);

            dbCon.Open();
            using (dbCon)
            {
                cmdInsertProduct.ExecuteNonQuery();
                SqlCommand cmdSelectIdentity = new SqlCommand("SELECT @@Identity", dbCon);
                int insertedId = (int)(decimal)cmdSelectIdentity.ExecuteScalar();
                Console.WriteLine("Added product :\nName: {0}\nSupplierID: {1}\nCategoryID {2}\nQualityPerUnit: {3}\nUnitPrice: {4}\nInserted With ID:{5}\n",
                    productName, supplierId, categoryId, unitPrice, quantityPerUnit, insertedId);
            }
        }
    }
}
