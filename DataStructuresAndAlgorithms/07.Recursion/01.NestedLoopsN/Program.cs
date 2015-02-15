namespace _01.NestedLoopsN
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Program
    {
        /*
        01.Write a recursive program that simulates the execution of n nested loops from 1 to n. Examples:
                                               1 1 1
                                               1 1 2
                                               1 1 3
                             1 1               1 2 1
                    n=2  ->  1 2      n=3  ->  ...
                             2 1               3 2 3
                             2 2               3 3 1
                                               3 3 2
                                               3 3 3
        */

        static void Main()
        {
            Console.WriteLine("Input n (if you type number bigger than 6 you will have bad time):");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            GenValue(0, arr);
        }

        static void GenValue(int index, int[] arr)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                for (int i = 1; i <= arr.Length; i++)
                {
                    arr[index] = i;
                    GenValue(index + 1, arr);
                }
            }
        }
    }
}
