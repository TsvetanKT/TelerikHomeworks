namespace NameAndDescriptionOfCategories
{
    using System;
    using System.Data.SqlClient;

    class NameAndDescriptionOfCategories
    {
        //02. Write a program that retrieves the name and description of all categories in the Northwind DB.

        static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server=.; " +
                "Database=Northwind; Integrated Security=true");
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand cmdNameAndDescriptionOfCategories = new SqlCommand(
                "SELECT CategoryName, Description FROM Categories", dbCon);
                SqlDataReader reader = cmdNameAndDescriptionOfCategories.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Name: " + (string)reader["CategoryName"]);
                        Console.WriteLine("Description: " + (string)reader["Description"]);
                        Console.WriteLine("----------------------------------------------");
                    }
                }
            }
        }
    }
}
