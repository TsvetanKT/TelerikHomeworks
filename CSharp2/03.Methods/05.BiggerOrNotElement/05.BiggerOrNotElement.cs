using System;

//05.Write a method that checks if the element at given position in given 
//   array of integers is bigger than its two neighbors (when such exist).

public class BiggerOrNotElement
{
    public static void PrintingArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" " + array[i]);
        }
        Console.WriteLine();
    }

    public static void CheckElement(int element, int[] array)
    {
        if ((element >= 0) && (element < array.Length))
        {
            if ((element > 0) && (element < (array.Length - 1)))
            {
                if ((array[element] > array[element + 1]) && (array[element] > array[element - 1]))
                {
                    Console.WriteLine("This element ({0}) IS bigger than its neighbors.", array[element]);
                }
                else
                {
                    Console.WriteLine("This element ({0}) IS NOT bigger than its neighbors.", array[element]);
                }
            }
            else
            {
                Console.WriteLine("This element ({0}) haves only one neighbor.", array[element]);
            }
        }
        else
        {
            Console.WriteLine("There is not element on this position !");
            return;
        }
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 2, 4, 44, 33 };
        Console.WriteLine("Array :");
        PrintingArray(array);
        Console.WriteLine();
        Console.Write("Enter position for check : ");
        int element = int.Parse(Console.ReadLine());
        Console.WriteLine();
        CheckElement(element, array);
        Console.WriteLine();

    }
}