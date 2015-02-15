using System;
using System.Threading;
using System.Globalization;

//14.Write methods to calculate minimum, maximum, average, 
//   sum and product of given set of integer numbers. 
//   Use variable number of arguments.


class MinMaxAvgSumProd
{
    public static int Min(params int[] numbers)
    {
        int min = numbers[0];

        foreach (int num in numbers)
        {
            if (num < min) min = num;
        }
        return min;
    }

    public static int Max(params int[] numbers)
    {
        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max) max = num;
        }
        return max;
    }

    public static double Avg(params int[] numbers)
    {
        return ((double)Sum(numbers) / numbers.Length);
    }

    public static int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers) sum += num;

        return sum;
    }

    public static decimal Product(params int[] numbers)
    {
        decimal product = 1;

        foreach (int num in numbers) product *= (decimal)num;
        return product;
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; //for problems with , and .
        Console.WriteLine("Min: " + Min(1, 2, 3, 4, -5, 6));
        Console.WriteLine("Max: " + Max(-3, 4, 5, 76, 34, 888, 7));
        Console.WriteLine("Sum: " + Sum(1, 2 , 3));
        Console.WriteLine("Avg: " + Avg(1, 2, 5, 8, 10));
        Console.WriteLine("Product: " + Product(-1, 2, 4, -2));
        Console.WriteLine();
    }
}
