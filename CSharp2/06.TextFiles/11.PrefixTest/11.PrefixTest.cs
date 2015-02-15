using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

//11.Write a program that deletes from a text file all words that start 
//   with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.

class PrefixTest
{
    static void Main()
    {
        StreamReader read = new StreamReader(@"..\..\..\TextFiles\Input11.txt");
        StreamWriter write = new StreamWriter(@"..\..\..\TextFiles\Answer11.txt");

        using (read)
        {
            using (write)
            {
                string searched = @"\btest\w{1,}"; // in this way, the word "test" will not be deleted , only the prefix test...
                Regex rege = new Regex(searched);

                for (string line = read.ReadLine(); line != null; line = read.ReadLine())
                {
                    string newLine = rege.Replace(line, String.Empty);
                    write.WriteLine(newLine);
                }
            }
        }
        Console.WriteLine("11.Ready!");
    }
}
