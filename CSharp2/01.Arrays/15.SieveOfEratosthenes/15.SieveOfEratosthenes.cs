using System;
using System.Collections.Generic;

class SieveOfEratosthenes
{
    static void Main()
    {
        //15.Write a program that finds all prime numbers in the range [1...10 000 000]. 
        //    Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

        List<int> numbers = new List<int>();
        int counter = 10000000;
        for (int i = 0; i <= counter; i++)
        {
            numbers.Add(i);
        }

        for (int i = 2; i < counter; i++)
        {
            if (numbers[i] != 0)
            {
                for (int k = numbers[i] * 2; k <= counter; k += numbers[i])
                {
                    numbers[k] = 0;
                }
                Console.WriteLine("{0} ", numbers[i]);
            }
        }
    }
}