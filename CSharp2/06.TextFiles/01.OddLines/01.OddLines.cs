using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//01.Write a program that reads a text file and prints on the console its odd lines.

class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\..\TextFiles\NamedLines.txt");

        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 ==1)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);                                      
                }
                lineNumber++;
                line = reader.ReadLine();
            }
        }
    }
}
