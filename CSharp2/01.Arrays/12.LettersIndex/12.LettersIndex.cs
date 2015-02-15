using System;

class LettersIndex
{
    static void Main()
    {
        //12.Write a program that creates an array containing all letters 
        //  from the alphabet (A-Z). Read a word from the console and print 
        //  the index of each of its letters in the array.

        char[] arr = new char[27];   //27 -> 0 element is null, 1 = a ... 26 = z
        string word = (Console.ReadLine().ToLower());

        for (int i = 1; i <= 26; i++)
        {
            arr[i] = Convert.ToChar('a' + (i-1));
        }

        for (int J = 0; J < word.Length; J++)
        {
            Console.WriteLine("Letter {0}  position [{1}]", word[J], (1+word[J]) - 'a');
        }
    }
}
