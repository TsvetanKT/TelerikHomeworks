using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//09.We are given a string containing a list of forbidden words and a text containing some
//   of these words. Write a program that replaces the forbidden words with asterisks. Example:
//   Microsoft announced its next generation PHP compiler today. It is based on .NET 
//   Framework 4.0 and is implemented as a dynamic language in CLR.
//   
//   Words: "PHP, CLR, Microsoft"
//   The expected result:
// 
//   ********* announced its next generation ***
//   compiler today. It is based on .NET Framework 4.0 
//   and is implemented as a dynamic language in ***.

class ForbiddenWordsInText
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        Console.WriteLine("09.Original text:\n"+text);
        string[] forbidenWords = { "Microsoft", "CLR", " PHP " };
        int length = forbidenWords.Length;

        for (int i = 0; i < length; i++)
        {
            text = text.Replace(forbidenWords[i], new string('*', forbidenWords[i].Length));
        }
        Console.WriteLine();
        Console.WriteLine("Text after the replacement:\n"+text);
    }
}