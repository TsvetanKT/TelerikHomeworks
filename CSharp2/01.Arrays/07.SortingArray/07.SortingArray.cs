using System;

class SortingArray
{
    static void Main()
    {
        //07.Sorting an array means to arrange its elements in increasing order. 
        // Write a program to sort an array. Use the "selection sort" algorithm: 
        // Find the smallest element, move it at the first position, find the smallest 
        // from the rest, move it at the second position, etc.

        int temp;

        Console.Write("Enter array length : ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] array = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Input {0} element : ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Before the sorting:");
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write(array[i] + " ");
        }

        for (int i = 0; i < arrayLength; i++)
        {
            int min = i;
            for (int j = i + 1; j < arrayLength; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }
            temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }

        Console.WriteLine();
        Console.WriteLine("After the sorting:");
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}