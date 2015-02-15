using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//23.Write a program that reads a string from the console and replaces all
//   series of consecutive identical letters with a single one. Example: 
//   "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".

class IidenticalLetterReplacer
{
    static void Main()
    {
        Console.Write("23.Enter your text: ");
        string input = Console.ReadLine();
        string removedConsecutives = RemoveingConsecutiveLetters(input);
        Console.WriteLine("The text without the consecutive identical letters:");
        Console.WriteLine(removedConsecutives);
    }
    private static string RemoveingConsecutiveLetters(string input)
    {
        var result = new StringBuilder();
        result.Append(input[0]);
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != result[result.Length - 1])
            {
                result.Append(input[i]);
            }
        }
        return result.ToString();
    }
}
