using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//10.Write a program that converts a string to a sequence of C# Unicode character 
//   literals. Use format strings. Sample input:
//   Hi!
//   Expected output:
//   \u0048\u0069\u0021

class UnicodeSequence
{
    static void Main()
    {
        string str = "Hello!";
        Console.WriteLine("10.Original string:\n"+str);
        Console.WriteLine("Converted to Unicode string:");
        foreach (var symbol in str)
        {
            Console.Write("\\u{0:X4}", (int)symbol);
        }
        Console.WriteLine();
    }
}