using System;

    class NotDivisibleBy3And7
    {
        static void Main()
        {
           // 02.Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

            Console.Write(" Input N (N>1) : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 != 0) || (i % 7 != 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

