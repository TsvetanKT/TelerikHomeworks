using System;
using System.Numerics;

    class FibonacciSumN
    {
        static void Main()
        {
            //07.Write a program that reads a number N and calculates the sum
            //of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13 …


            Console.Write(" N = ");
            int inputN = int.Parse(Console.ReadLine());

            if (inputN > 0)
            {

                BigInteger firstNum = 0;
                BigInteger secondNum = 1;
                BigInteger nextNum;
                BigInteger sum;

                sum = firstNum + secondNum;
                for (int i = 2; i < inputN; i++)
                {
                    nextNum = firstNum + secondNum;
                    sum += nextNum;
                    firstNum = secondNum;
                    secondNum = nextNum;
                }

                Console.WriteLine(" The sum of the first {0} members of the Fibonacci sequence is : {1} ", inputN, sum);
            }
            else
            {
                Console.WriteLine(" N must be bigger than zero !");
                Main();
            }

        }
    }
