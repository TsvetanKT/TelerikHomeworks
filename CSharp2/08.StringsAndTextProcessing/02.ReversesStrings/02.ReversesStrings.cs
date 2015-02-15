using System;
using System.Text;

//02.Write a program that reads a string, reverses it and prints the result at the console.
//   Example: "sample" -> "elpmas".

class ReversesStrings
{
    static void Main()
    {
        Console.WriteLine("02.Enter a string :");
        string text = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        for (int i = text.Length - 1; i >= 0; i--)
        {
            sb.Append(text[i]);
        }
        Console.WriteLine("Reversed:");
        Console.WriteLine(sb.ToString());
    }
}
