using System;

    class PrintingFrom1ToN
    {
        static void Main()
        {
            //01.Write a program that prints all the numbers from 1 to N.

            Console.Write(" Input N (N>1) : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
			{
                Console.WriteLine(i);			 
			}
        }
    }
