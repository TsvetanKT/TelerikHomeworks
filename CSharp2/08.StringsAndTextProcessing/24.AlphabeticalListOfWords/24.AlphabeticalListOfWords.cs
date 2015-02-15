using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//24.Write a program that reads a list of words, separated by spaces and prints the 
//   list in an alphabetical order.


class AlphabeticalListOfWords
{
    static void Main()
    {
        Console.WriteLine("24.Enter your text:");
        string[] input = Console.ReadLine().Split(' ');
        Array.Sort(input);
        Console.WriteLine("Alphabetical order of the words :");
        foreach (string word in input)
        {
            if (word == "")  // Removing empty spaces if any exist.
            {
                continue;
            }
            Console.WriteLine(word);
        }
    }
}
