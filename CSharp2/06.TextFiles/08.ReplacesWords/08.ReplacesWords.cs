using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

//08.Modify the solution of the previous problem to replace only whole words (not substrings).
//-07.Write a program that replaces all occurrences of the substring "start"
//    with the substring "finish" in a text file. Ensure it will work with 
//    large files (e.g. 100 MB).

class ReplacesWords
{
    static void Main()
    {
        StreamReader read = new StreamReader(@"..\..\..\TextFiles\Input07.txt");
        StreamWriter write = new StreamWriter(@"..\..\..\TextFiles\Answer08.txt");

        using (read)
        {
            using (write)
            {
                string searched = @"\b(start)\b";
                Regex rege = new Regex(searched);

                for (string line = read.ReadLine(); line != null; line = read.ReadLine())
                {
                    string newLine = rege.Replace(line, "finish");
                    write.WriteLine(newLine);
                }
            }
        }

        Console.WriteLine("Done.");
    }
}