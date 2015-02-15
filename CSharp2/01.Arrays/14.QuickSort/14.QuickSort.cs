using System;

class QuickSort
{
    static void Main()
    {
        //14.Write a program that sorts an array of strings using 
        //   the quick sort algorithm (find it in Wikipedia).

        Console.Write("Enter array length : ");    
        int n = int.Parse(Console.ReadLine());
        string[] unsorted = new string[n];

        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write("Element {0} : ",i);
            unsorted[i] = Console.ReadLine();
        }

        Console.WriteLine();

        Quicksort(unsorted, 0, n - 1);  //Sorting the array

        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }

        Console.WriteLine();
    }

    public static void Quicksort(IComparable[] elements, int left, int right)
    {
        int i = left, j = right;
        IComparable pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                IComparable tmp = elements[i];  //the elements are changing places
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }

        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }
}
