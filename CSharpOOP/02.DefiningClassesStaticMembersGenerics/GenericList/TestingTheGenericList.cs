using System;

class Program
{
    //05.Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
    //   Keep the elements of the list in an array with fixed capacity which is given as parameter in 
    //   the class constructor. Implement methods for adding element, accessing element by index, 
    //   removing element by index, inserting element at given position, clearing the list, finding 
    //   element by its value and ToString(). Check all input parameters to avoid accessing elements 
    //   at invalid positions.
    //
    //06.Implement auto-grow functionality: when the internal array is full, create a new array of 
    //   double size and move all elements to it.
    //
    //07.Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element 
    //   in the  GenericList<T>. You may need to add a generic constraints for the type T.

    static void Main()
    {
        GenericList<int> list = new GenericList<int>();

        {
            Console.WriteLine("Incresing / Decresing");

            uint temp = list.Capacity;
            for (int i = 0; i < 10000; i++)
            {
                list.Add(i);
                if (i == 0 || temp != list.Capacity)
                {
                    Console.WriteLine("list.Count: {0}, list.Capacity: {1}", list.Count, list.Capacity);
                    temp = list.Capacity;
                }
                
            }

            while (list.Count > 16)
            {
                list.Remove(list.Count - 1);

                if (list.Count == 9999||temp != list.Capacity)
                {
                    Console.WriteLine("list.Count: {0}, list.capacity: {1}", list.Count, list.Capacity);
                    temp = list.Capacity;
                }
            }

            Console.WriteLine();
        }

        {
            Console.WriteLine("-- List is");

            Console.WriteLine(list);

            Console.WriteLine();
        }

        {
            Console.WriteLine("-- Min: {0}", list.Min());
            Console.WriteLine("-- Max: {0}", list.Max());

            Console.WriteLine();
        }

        {
            Console.WriteLine("-- Indexer");

            Console.WriteLine(list[2]);

            Console.WriteLine();
        }

        {
            Console.WriteLine("-- Remove element");

            list.Remove(3);

            Console.WriteLine(list);

            Console.WriteLine();
        }

        {
            Console.WriteLine("-- Add element");

            list.Insert(0, 10);
            list.Insert(3, 5);
            list.Insert(list.Count, 11);

            Console.WriteLine(list);

            Console.WriteLine();
        }

        {
            Console.WriteLine("-- Index of");

            Console.WriteLine(list.IndexOf(4));

            Console.WriteLine();
        }

        {
            Console.WriteLine("-- Clear");

            list.Clear();

            Console.WriteLine(list);
        }
    }
}