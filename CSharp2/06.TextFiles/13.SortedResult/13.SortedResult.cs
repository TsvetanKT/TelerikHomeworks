using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//13.Write a program that reads a list of words from a file words.txt and finds
//   how many times each of the words is contained in another file test.txt. 
//   The result should be written in the file result.txt and the words should 
//   be sorted by the number of their occurrences in descending order. Handle 
//   all possible exceptions in your methods.

class SortedResult
{
    static void Main()
    {
        try
        {
            /*Files :
             * words.txt  = Input12WordsForRemoving.txt
             * test.txt   = Input13.txt
             * result.txt = Answer13.txt
            */
            var words = File.ReadAllLines(@"..\..\..\TextFiles\Input12WordsForRemoving.txt", Encoding.Default).ToDictionary(line => line, line => 0);
            using (var reader = new StreamReader(@"..\..\..\TextFiles\Input13.txt", Encoding.Default))
                while (!reader.EndOfStream)
                {
                    var temp = new StringBuilder();
                    foreach (var character in (reader.ReadLine()+" "))// + " " cuz my program haved troubles for when the word is in the end of the row
                    {
                        if (!char.IsLetter(character))
                        {
                            if (words.ContainsKey(temp.ToString()))
                        words[temp.ToString()]++;
                        temp.Clear();
                        }
                        else temp.Append(character);
                    }
                }
            File.WriteAllLines(@"..\..\..\TextFiles\Answer13.txt", (from item in words orderby item.Value descending select string.Format(item.Key+" " +item.Value)).ToArray());
        }
        catch (Exception e)
        {
            Console.WriteLine("{0}:{1}", e.GetType().Name, e.Message);
        }
        Console.WriteLine("13.Ready!");
    }
}
