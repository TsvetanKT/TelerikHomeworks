using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//02.Write a program that concatenates two text files into another text file.

class ConcatenatesFiles
{
    static void Main()
    {

        StreamReader readerOne = new StreamReader(@"..\..\..\TextFiles\NamedLines.txt");
        StreamReader readerTwo = new StreamReader(@"..\..\..\TextFiles\RandomText.txt");
        StreamWriter streamWriter = new StreamWriter(@"..\..\..\TextFiles\Answer02.txt");

        using (streamWriter)
        {

            using (readerOne)
            {
                string fileContentOne = readerOne.ReadToEnd(); //copy the first file's text
                streamWriter.Write(fileContentOne);  //paste the first file's text
            }

            using (readerTwo)
            {
                string fileContentTwo = readerTwo.ReadToEnd();//copy the second file's text
                streamWriter.Write(fileContentTwo);  //paste the second file's text
            }
        }

        Console.WriteLine("Done.");
    }
}
