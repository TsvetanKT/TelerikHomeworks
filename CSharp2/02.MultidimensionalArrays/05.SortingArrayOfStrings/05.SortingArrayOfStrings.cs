using System;
using System.Linq;

class SortingArrayOfStrings
{
    static void Main()
    {
        //05.You are given an array of strings. Write a method that sorts the array
        //   by the length of its elements (the number of characters composing them).

        Console.Write("Number of elements in the array : ");
        int n = int.Parse(Console.ReadLine());
        string[] matrix = new string[n];
        Console.WriteLine();

        Console.WriteLine("Imputing elements :");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("Element [{0}] = ", i);
            matrix[i] = Console.ReadLine();
            
        }
        Console.WriteLine();

        Sorting(matrix);
        foreach (var item in matrix)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }

    static void Sorting(string[] array)
    {
        int[] stringsLenghts = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            stringsLenghts[i] = array[i].Length;
        }
        Array.Sort(stringsLenghts, array);
       return;
    }
}
