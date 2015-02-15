using System;
using System.Numerics;

//10.Write a program to calculate n! for each n in the range [1..100].
//   Hint: Implement first a method that multiplies a number represented
//   as array of digits by given integer number.

class FactorialCalculator
{
    static void Main()
    {
        int[] array = new int[100];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        CalculatingFacturial(array);

    }
    static void CalculatingFacturial(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            BigInteger factorial = Factorial(i);
            Console.WriteLine(factorial);
        }
    }
    static BigInteger Factorial(int i)
    {
        if (i > 1)
        {
            BigInteger fact = i;
            while (i > 1)
            {               
                fact =fact*(i-1);
                i--;                             
            }
            return fact;
        }
        else 
        {
            return 1;
        }
    }
}