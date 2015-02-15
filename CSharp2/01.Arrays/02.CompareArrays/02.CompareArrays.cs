using System;

class CompareArrays
{
    static void Main()
    {
        //02.Write a program that reads two arrays from the console and compares them element by element.

        Console.Write("Specify array length (number of elements) : ");
        int n = int.Parse(Console.ReadLine());

        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        bool equal = true;
        char sign;

        Console.WriteLine("Values for array 1 :");
        for (int i = 0; i < n; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("Values for array 2 :");
        for (int i = 0; i < n; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());          
        }

        Console.WriteLine();
        Console.WriteLine("Comparing elements :");
        for (int i = 0; i < n; i++)
        {
            sign = '=';
            if (firstArray[i] > secondArray[i])
            {
                sign = '>';
                equal = false;
            }
            else if (firstArray[i] < secondArray[i])
            {
                sign = '<';
                equal = false;
            }
            Console.WriteLine("Element {0}: {1} {2} {3}", i, firstArray[i],sign ,secondArray[i]);


        }
        Console.WriteLine();
        Console.Write("The arrays are equal -> " + equal);
        Console.WriteLine();
    }
}