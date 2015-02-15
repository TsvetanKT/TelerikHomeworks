using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//21.Write a program that reads a string from the console and prints all 
//   different letters in the string along with information how many 
//   times each letter is found. 

class LetterCounter
{
    static void Main()
    {
        string[] forbidenSigns = { " ", "*", "(", ")", "-", "_", "+", ".", "!", "@", "#", "$", "%", "^", "&" };

        Console.Write("21.Enter your text: ");
        string input = Console.ReadLine();

        for (int i = 0; i < forbidenSigns.Length; i++)
        {
            input = input.Replace(forbidenSigns[i], string.Empty); //We are not counting the chars from the forbidenSigns array
        }

        Dictionary<char, int> allLetters = new Dictionary<char, int>();
        for (int i = 0; i < input.Length; i++)
        {
            if (allLetters.ContainsKey(input[i]))
            {
                allLetters[input[i]]++;
            }
            else
            {
                allLetters.Add(input[i], 1);
            }
        }

        var sortedLetters = allLetters.OrderBy(x => x.Key);
        foreach (var item in sortedLetters)
        {
            Console.WriteLine("Letter {0} is found {1} times.", item.Key, item.Value);
        }
    }
}
