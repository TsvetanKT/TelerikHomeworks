using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//03.Write a program that reads a text file and inserts line numbers in front 
//   of each of its lines. The result should be written to another text file.

class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\..\TextFiles\NamedLines.txt");
        StreamWriter writer = new StreamWriter(@"..\..\..\TextFiles\Answer03.txt");

        using (writer)
        {
            using (reader)
            {
                int count = 0;  // i want first line to be 0 line, not 1
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.Write("Line {0}: ", count);
                    writer.WriteLine(line);
                    count++;
                }
            }
        }

        Console.WriteLine("Done.");
    }
}
