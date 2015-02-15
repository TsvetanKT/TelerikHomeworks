using System;

class FromOneToN
{

    static void Main()
    {
        Console.WriteLine("08.Write a program that reads an integer number n from the console");
        Console.WriteLine("and prints all the numbers in the interval [1..n], each on a single line.");
        Console.WriteLine();
        Console.Write(" Input n : ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < n + 1; i++)
        {
            Console.WriteLine(i);
        }
    }
}
