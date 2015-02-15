using System;

class TwoNumberDevision
{
    static int counter(int a, int b)
    {
        if (a > b)
        {
            return 0;
        }
        else
        {
            if (a % 5 == 0)
            {
                return (1 + counter(a + 5, b));
            }
            else
            {
                return counter(a + 1, b);
            }
        }
    }


    static void Main()
    {
        Console.WriteLine("04.Write a program that reads two positive integer numbers and prints ");
        Console.WriteLine("how many numbers p exist between them such that the reminder of the ");
        Console.WriteLine("division by 5 is 0 (inclusive). Example: p(17,25) = 2.");
        Console.WriteLine();
        Console.Write(" Input first number : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write(" Input second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine(" p({0},{1}) = {2}\n", a, b, counter(a, b));
    }
}