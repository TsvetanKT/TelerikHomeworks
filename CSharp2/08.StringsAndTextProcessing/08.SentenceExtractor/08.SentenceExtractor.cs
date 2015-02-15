using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//08.Write a program that extracts from a given text all sentences containing given word.
//		Example: The word is "in". The text is:
//   We are living in a yellow submarine. We don't have anything else. Inside the submarine 
//   is very tight. So we are drinking all the day. We will move out of it in 5 days.
//
//   The expected result is:
//   We are living in a yellow submarine.
//   We will move out of it in 5 days.
//
//Consider that the sentences are separated by "." and the words – by non-letter symbols.

class SentenceExtractor
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";
        string[] sentences = text.Split('.');
        Console.WriteLine("08.Original text :\n"+text);
        Console.WriteLine();
        Console.WriteLine("Result:");

        for (int i = 0; i < sentences.Length; i++)
        {
            if (Regex.Matches(sentences[i], @"\b" + word + @"\b").Count > 0)
            {
                Console.WriteLine((sentences[i] + ".").Trim());
            }
        }
    }
}