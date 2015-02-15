using System;

//03.Write a method that returns the last digit of given integer as an
//   English word. Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".

class LastDigitOfInt
{
    static string[] digitNames = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

    static string DigitName(int n)
    {
        return digitNames[n];
    }

    static int InspectLastDigit(int n)
    {
        return n % 10;
    }

    static void Main()
    {
        Console.WriteLine("Input your number :");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("The last digit of your number is "+ DigitName(InspectLastDigit(num)));
    }
}
