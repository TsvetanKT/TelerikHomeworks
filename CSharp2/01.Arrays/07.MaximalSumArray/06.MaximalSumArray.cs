using System;
using System.Linq;

class MaximalSumArray
{
    static void Main()
    {
        //06. Write a program that reads two integer numbers N and K and an array of N 
        //    elements from the console. Find in the array those K elements that have maximal sum.


        Console.Write("Specify array length N : ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Specify number of elements K : ");
        int K = int.Parse(Console.ReadLine());
        int sum = 0;
        int[] arrayN = new int[N];
        for (int i = 0; i < N; i++)
        {
            arrayN[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Array.Sort(arrayN);            //sorting the array

        Console.Write("With maximal sum are the elements: ");
        for (int i = N - K; i < N; i++)      //taking the last K element (the biggest) after the sorting
        {
            sum += arrayN[i];
            if (i == (N - K))
            {
                Console.Write(arrayN[i]);
            }
            else
            {
                Console.Write(", " + arrayN[i]);
            }
        }
        Console.WriteLine();
        Console.WriteLine("The sum is {0}",sum);
    }
}
