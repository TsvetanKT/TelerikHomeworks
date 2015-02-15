using System;

class BinSearchNumber
{
    static void Main()
    {
        //04.Write a program, that reads from the console an array of N integers
        //   and an integer K, sorts the array and using the method Array.BinSearch() 
        //   finds the largest number in the array which is ≤ K. 

        Console.Write("Number of elements in the array : ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Console.WriteLine();

        Console.WriteLine("Imputing elements :");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Element [{0}] = ",i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.Write("Enter K : ");
        int k = int.Parse(Console.ReadLine());


        Array.Sort(numbers);
        int index = Array.BinarySearch(numbers, k);

        if (numbers[0] > k)
        {
            Console.WriteLine("There isn't such number in the array !");
        }
        else
        {
            if (index >= 0)
            {
                Console.WriteLine("The largest number in the array, equal or less to K ({0}) is {1}.",k ,numbers[index]);
            }
            else
            {
                Console.WriteLine("The largest number in the array which is less or equal to K ({0}) is {1}.",k , numbers[-index - 2]);
            }
        }
        Console.WriteLine();
    }
}
