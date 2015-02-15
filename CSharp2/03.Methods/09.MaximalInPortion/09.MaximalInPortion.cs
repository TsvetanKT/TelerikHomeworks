using System;

//09.Write a method that return the maximal element in a portion of
//   array of integers starting at given index. Using it write another
//   method that sorts an array in ascending / descending order.


class MaximalInPortion
{
    static void Main()
    {
        Console.WriteLine("Starting array :");
        int[] array = { 1, 34, 3245, 234, 234, 12, 321, 1231, 1, 3, 4, 5, 3, 2, 666 };

        PrintArray(array);
        Console.WriteLine();
        Sort(array, array.Length);

        Console.WriteLine("Ascending:");
        PrintArray(array);

        //printing the reversed array
        Array.Reverse(array);
        Console.WriteLine();
        Console.WriteLine("Descending:");
        PrintArray(array);
        Console.WriteLine();

    }

    static void Sort(int[] arr, int length)
    {
        length--;
        if (length < 1)
        {
            return;
        }
        int maxIndex = FindMaxElement(arr, length);

        int temp = arr[maxIndex];
        arr[maxIndex] = arr[length];
        arr[length] = temp;

        Sort(arr, length);
    }

    static int FindMaxElement(int[] arr, int length)
    {
        int maxElement = int.MinValue;
        int maxIndex = 0;
        for (int i = 0; i <= length; i++)
        {
            if (arr[i] > maxElement)
            {
                maxElement = arr[i];
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

