using System;
using System.Threading;
using System.Globalization;

//07.Write a method that reverses the digits of given decimal number. Example: 256 -> 652


class ReversingDecimal
{
    static void ReversingTheNumber(decimal number)
    {
        string reversed = number.ToString();

        char[] charArray = reversed.ToCharArray();
        Array.Reverse(charArray);
        new string(charArray);
        Console.WriteLine(charArray);
    }


    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; //for problems with , and .
        Console.Write("Enter your number : ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Your reversed number is :");
        ReversingTheNumber(number);
        Console.WriteLine();
    }
}

