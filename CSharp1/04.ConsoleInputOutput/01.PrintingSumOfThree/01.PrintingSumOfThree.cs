using System;

class PrintingSumOfThree
{
    static void Main()
    {
        Console.WriteLine("01.Write a program that reads 3 integer numbers from the console and prints their sum.");
        Console.WriteLine();
        Console.Write(" Input furst number  : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write(" Input second number : ");
        int b = int.Parse(Console.ReadLine());
        Console.Write(" Input third number  : ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine(" {0} + {1} + {2} =  {3}", a, b, c, a + b + c);
    }
}
