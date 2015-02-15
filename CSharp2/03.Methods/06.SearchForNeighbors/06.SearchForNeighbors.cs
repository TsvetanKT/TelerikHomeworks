using System;

//06.Write a method that returns the index of the first element in array
//   that is bigger than its neighbors, or -1, if there’s no such element.

class SearchForNeighbors
{
    public static void PrintingArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" " + array[i]);
        }
        Console.WriteLine();
    }

    public static int CheckElements(int[] array) //can't use the method from the previous exercise cuz it works diferently.
    {
        for (int i = 1; i < (array.Length-1); i++)
        {
            if ((array[i - 1] < array[i]) && (array[i + 1] < array[i]))
            {
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 2, 4, 44, 33 };
        //int[] array = { 1, 2, 3, 4, 5, 6, 7, 44, 77 };
        Console.WriteLine("Array :");
        PrintingArray(array);
        Console.WriteLine();
        Console.WriteLine("First element in array that is bigger than its neighbors :");
        Console.WriteLine("Position : "+CheckElements(array));
        if (CheckElements(array)>-1)
        {
            Console.WriteLine("Elements : {0} < {1} > {2}", array[(CheckElements(array) - 1)],
                array[CheckElements(array)], array[(CheckElements(array) + 1)]);
        }
        Console.WriteLine();
    }
}