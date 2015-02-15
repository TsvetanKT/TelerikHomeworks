using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//04.Write a program that compares two text files line by line and prints 
//   the number of lines that are the same and the number of lines that are
//   different. Assume the files have equal number of lines.

class CcomparesTwoFiles
{
    static void Main()
    {
        StreamReader readerOne = new StreamReader(@"..\..\..\TextFiles\NamedLines.txt");
        StreamReader readerTwo = new StreamReader(@"..\..\..\TextFiles\NamedLines04.txt");
        using (readerOne)
        {
            using (readerTwo)
            {
                string firstFileLines, secondFileLines;
                int differentLines = 0; 
                int equalLines = 0;

                while ((firstFileLines = readerOne.ReadLine()) != null && (secondFileLines = readerTwo.ReadLine()) != null)
                {
                    if (firstFileLines == secondFileLines) equalLines++;
                    else differentLines++;
                }
                Console.WriteLine("Total lines: " + (differentLines + equalLines));
                Console.WriteLine("Same lines: " + equalLines);
                Console.WriteLine("Different lines: "+differentLines);
            }
        }
    }
}
