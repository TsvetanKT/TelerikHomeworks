using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        //07.Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
        static void Main()
        {          
            Console.WriteLine(" Input number :");
            int n = int.Parse(Console.ReadLine());
            bool isPrime = false;
            if ((n > 100) || (n < 2))
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < Math.Sqrt(n); i++)
                {
                    if ((n % i) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                    }
                }
            }

            Console.WriteLine(" Is number {0} prime number? : {1}", n, isPrime);
        }
    }
}
