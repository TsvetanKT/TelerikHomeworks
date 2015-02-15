using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//20.Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

class PalindromesExtractor
{
    static void Main()
    {
        string text = @"Write a program that extracts from a given text all palindromes, e.g. WoW, ABBA, lamal, exe.";
        Console.WriteLine("20.Original text:\n"+text);
        char[] separators = { ' ', ',', '.', '!', '\n', '\r' }; 
        string[] splitted = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine();
        Console.WriteLine("Palindromes in the text:");
        foreach (string word in splitted)
        {
            bool isPalindrome = true;
            for (int j = 0; j < (word.Length / 2); j++)
            {
                if (word[j] != word[word.Length - 1 - j])
                {
                    isPalindrome = false;
                    break;
                }
            }
            
            if (isPalindrome && word.Length > 1)
            {
                Console.WriteLine(word);
            }
        }
    }
}