using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

//07.Write a program that replaces all occurrences of the substring "start"
//   with the substring "finish" in a text file. Ensure it will work with 
//   large files (e.g. 100 MB).

class ReplacesSubsrings
{
    static void Main()
    {
        string start = "start";
        string finish = "finish";
        StreamReader read = new StreamReader(@"..\..\..\TextFiles\Input07.txt");
        StreamWriter write = new StreamWriter(@"..\..\..\TextFiles\Answer07.txt");
        string currentLine = "";
 
        using (read)
        {
            using (write)
            {
                currentLine = read.ReadLine();
                while (currentLine != null)
                {
                    currentLine = currentLine.Replace(start, finish);
                    write.WriteLine(currentLine);
                    currentLine = read.ReadLine();
                }
                Console.WriteLine("Ready!");
            }
        }
    }
}
