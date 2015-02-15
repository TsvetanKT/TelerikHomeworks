using System;

class GreaterFromTwoNumbers
{
    static void Main()
    {
        Console.WriteLine("05.Write a program that gets two numbers from the console and");
        Console.WriteLine("prints the greater of them. Don’t use if statements.");
        Console.WriteLine();
        Console.Write(" Input first number : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write(" Input second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write(" The greater number is : ");
        int temp = a >= b ? a : b;
        Console.WriteLine(temp);
    }
}