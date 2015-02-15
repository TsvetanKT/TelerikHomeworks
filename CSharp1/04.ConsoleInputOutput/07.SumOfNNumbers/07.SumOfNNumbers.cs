using System;

class SumOfNNumbers
{

    static void Main()
    {
        Console.WriteLine("07.Write a program that gets a number n and after that gets more");
        Console.WriteLine(" n numbers and calculates and prints their sum.");
        Console.WriteLine();
        Console.Write(" Input number for n : ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            Console.Write(" Number {0} = ", i + 1);
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine(" The sum is : {0}",sum);
    }
}