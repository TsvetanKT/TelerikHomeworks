namespace NewRowsToExcel
{
    using System;
    using System.Collections.Generic;
    using System.Data.OleDb;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class NewRowsToExcel
    {
        static void Main()
        {
            
            Console.WriteLine("Input name:");
            string name = Console.ReadLine();

            Console.WriteLine("Score for {0}:", name);
            string score = Console.ReadLine();
     
            OleDbConnectionStringBuilder connectionBuilder = new OleDbConnectionStringBuilder();
            connectionBuilder.Provider = "Microsoft.ACE.OLEDB.12.0";

            string fileName = "HomeworkExcel.xlsx";
            connectionBuilder.DataSource = @"..\..\" + fileName;
            connectionBuilder.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES");

            OleDbConnection connectionExcel = new OleDbConnection(connectionBuilder.ConnectionString);
            OleDbCommand cmdAppendRow = new OleDbCommand(
                "INSERT INTO [TestPage$](Name, Score) VALUES('" + name + "','" + score + "')", connectionExcel);

            connectionExcel.Open();

            using (connectionExcel)
            {
                int rowsAffected = cmdAppendRow.ExecuteNonQuery();
                Console.WriteLine("{0} rows affected.", rowsAffected);
            }
            Console.WriteLine("\nSee the folder of the current project.");
        }
    }
}
