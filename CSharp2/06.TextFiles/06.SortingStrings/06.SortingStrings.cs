using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/*06.Write a program that reads a text file containing a list of strings, 
    sorts them and saves them to another text file. Example:
    Ivan			George
	Peter     ->	Ivan
	Maria			Maria
	George			Peter
*/

class SortingStrings
{
    static void Main()
    {
        PrintingOnFile(ReadingNames());
        Console.WriteLine("The strings are sorted and saved successfully!");
    }

    static List<string> ReadingNames()
    {
        List<string> unsorted = new List<string>();
        StreamReader names = new StreamReader(@"..\..\..\TextFiles\RandomText.txt", Encoding.GetEncoding("windows-1251"));
        using (names)
        {
            string currentLine;
            while ((currentLine = names.ReadLine()) != null)
            {
                unsorted.Add(currentLine);
            }
        }
        return unsorted;
    }

    static void PrintingOnFile(List<string> sorted)
    {
        sorted.Sort();
        StreamWriter writer = new StreamWriter(@"..\..\..\TextFiles\Answer06.txt", false, Encoding.GetEncoding("windows-1251"));
        using (writer)
        {
            for (int i = 0; i < sorted.Count; i++)
            {
                writer.WriteLine((sorted[i]));
            }

        }
    }
}