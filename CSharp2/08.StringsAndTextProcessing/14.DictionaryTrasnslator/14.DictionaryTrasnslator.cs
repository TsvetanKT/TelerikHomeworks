using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//14.A dictionary is stored as a sequence of text lines containing words and their 
//   explanations. Write a program that enters a word and translates it by using 
//   the dictionary. Sample dictionary:
//   .NET – platform for applications from Microsoft
//   CLR – managed execution environment for .NET
//   namespace – hierarchical organization of classes


class DictionaryTrasnslator
{
    static void Main()
    {
        string[] dictionary = { ".NET - platform for applications from Microsoft",
                                "CLR - managed execution environment for .NET",
                                "NAMESPACE - hierarchical organization of classes",};

        Console.WriteLine("14.Enter word in the Dictionary: namecpace");
        string word = "namespace"; //This shoud be our input
        foreach (string line in dictionary)
        {
            if (line.IndexOf(word.ToUpper() + " -")== 0) //Shows result that are matching only the first position in the rolls of the dictionary
            {
                Console.WriteLine(line);
            }
        }
    }
}