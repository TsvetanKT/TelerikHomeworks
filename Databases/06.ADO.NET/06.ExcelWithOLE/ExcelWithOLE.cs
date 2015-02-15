namespace ExcelWithOLE
{
    using System;
    using System.Collections.Generic;
    using System.Data.OleDb;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        // 06. Create an Excel file with 2 columns: name and score:
        //      Write a program that reads your MS Excel file 
        //      through the OLE DB data provider and displays the 
        //      name and score row by row.

        static void Main()
        {
            OleDbConnectionStringBuilder connectionBuilder = new OleDbConnectionStringBuilder();
            connectionBuilder.Provider = "Microsoft.ACE.OLEDB.12.0";

            string fileName = "HomeworkExcel.xlsx";
            connectionBuilder.DataSource = @"..\..\" + fileName;
            connectionBuilder.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES");
            OleDbConnection connectionExcel = new OleDbConnection(connectionBuilder.ConnectionString);
            OleDbCommand cmdGetNamesAndScores = new OleDbCommand("SELECT * FROM [TestPage$]", connectionExcel);

            connectionExcel.Open();

            using (connectionExcel)
            {
                OleDbDataReader reader = cmdGetNamesAndScores.ExecuteReader();
                while (reader.Read())
                {
                    string name = (string)reader["Name"];
                    double score = (double)reader["Score"];
                    Console.WriteLine("Name: {0} - Points: {1}", name, score);
                }
            }
        }
    }
}
