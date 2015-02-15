namespace ImagesToJPG
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ImagesToJPG
    {
        //05. Write a program that retrieves the images for all categories in the Northwind database and stores them as JPG files in the file system.

        public static void Main()
        {
            byte[] pictureFromDB;
            string categoryName;

            SqlConnection dbCon = new SqlConnection("Server=.; " +
                "Database=Northwind; Integrated Security=true");

            dbCon.Open();
            using (dbCon)
            {
                SqlCommand cmdGetCategoriesImages = new SqlCommand(
                "SELECT CategoryName, Picture " +
                "FROM Categories", dbCon);

                SqlDataReader reader = cmdGetCategoriesImages.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        pictureFromDB = (byte[])reader["Picture"];
                        categoryName = (string)reader["CategoryName"];
                        categoryName = categoryName.Replace("/", string.Empty);
                        string fileName = @"..\..\" + categoryName + ".jpg";

                        FileStream stream = File.OpenWrite(fileName);
                        using (stream)
                        {
                            stream.Write(pictureFromDB, 78, pictureFromDB.Length - 78);
                        }
                    }
                }
                Console.WriteLine("Done.\nSee the folder of the current project.");
            }
        }
    }
}
