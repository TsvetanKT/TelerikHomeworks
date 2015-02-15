using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

//12.Write a program that removes from a text file all words listed in given
//   another text file. Handle all possible exceptions in your methods.

class RemovingWords
{
    static void Main()
    {
        try
        {
            string allLines = String.Join(" ", File.ReadAllLines(@"..\..\..\TextFiles\Input12WordsForRemoving.txt"));
            string[] allWords = allLines.Split(' ');
            StreamReader start = new StreamReader(@"..\..\..\TextFiles\Input12.txt", Encoding.GetEncoding("windows-1251"));
            using (start)
            {
                StreamWriter finish = new StreamWriter(@"..\..\..\TextFiles\Answer12.txt", false, Encoding.GetEncoding("windows-1251"));
                string line = start.ReadLine();
                using (finish)
                {
                    while (line != null)
                    {
                        for (int i = 0; i < allWords.Length; i++)
                        {
                            string word = "\\b" + allWords[i] + "\\b"; //this program deletes only whole words, not prefixes
                            line = Regex.Replace(line, word, "");
                        }

                        finish.WriteLine(line);
                        line = start.ReadLine();
                    }
                }
            }
            Console.WriteLine("Whole words only have been replaced!");
        }     
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The entered file path is not correct!");
        }
        catch (SecurityException)
        {
            Console.WriteLine("You don't have the required permission to access this file!");
        }
    }
}