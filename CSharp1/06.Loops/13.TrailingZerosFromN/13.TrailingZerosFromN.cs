using System;
using System.Numerics;

    class TrailingZerosFromN
    {
        static void Main()
        {
            //13.* Write a program that calculates for given N how many trailing zeros 
            //present at the end of the number N!. Examples:
            //N = 10 -> N! = 3628800 -> 2
            //N = 20 -> N! = 2432902008176640000 -> 4
	        //Does your program work for N = 50 000?
	        //Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!

            Console.Write(" Insert N : ");
            int n = int.Parse(Console.ReadLine());

            BigInteger factorialN = 1;
            int counterZero = 0;
            int divider = 5; // N! trailing zeros = n/5 + n/25 + n/125 + n/625 + ... + ... + ...

            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }

            Console.WriteLine(" N! = {0}", factorialN);

            while (n >= divider)
            {
                counterZero += (n / divider);
                divider *= 5;
            }

            Console.WriteLine(" There are {0} trailing zeroes at the end of (N!)", counterZero);
        }
    }

