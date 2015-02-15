namespace CombinationsWithDuplicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        //02.Write a recursive program for generating and printing all the combinations
        //    with duplicates of k elements from n-element set. Example:
        //    n=3, k=2 -> (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)

        static void Main()
        {
            int k = 2;
            int[] arr = new int[k];
            int start = 1;
            int n = 4; 
            StringBuilder sb = new StringBuilder();
            GenValue(0, arr, start, n, sb);
            Console.WriteLine(sb.ToString().Remove(sb.Length - 1, 1));
        }
        static void GenValue(int index, int[] arr, int start, int end, StringBuilder sb)
        {
            if (index >= arr.Length)
            {
                Print(arr, sb);
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    GenValue(index + 1, arr, arr[0], end, sb);
                }
            }
        }

        private static void Print(int[] arr, StringBuilder sb)
        {
            sb.Append("(" + String.Join(" ", arr) + ")\n");
        }
    }
}
