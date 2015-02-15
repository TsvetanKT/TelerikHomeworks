using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//13.Write a program that reverses the words in given sentence.
//	Example: "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!".

class SentenceReverser
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        Console.WriteLine("13.Original text :\n"+text);
        char[] separators = new char[] { ',', ' ', '!', '?', '.' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);

        string[] arr = Regex.Split(text, "[A-Za-z0-9#+]");
        List<string> nonLetters = new List<string>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != String.Empty)
            {
                nonLetters.Add(arr[i]); //Adding chars that are not letters and not an empty space.
            }
        }

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < nonLetters.Count; i++)
        {
            if (i < words.Length)
            {
                result.Append(words[i]);
            }

            result.Append(nonLetters[i]);
        }
        Console.WriteLine("Result:\n"+result.ToString());
    }
}