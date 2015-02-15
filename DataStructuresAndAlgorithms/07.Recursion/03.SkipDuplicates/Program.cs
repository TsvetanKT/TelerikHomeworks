namespace SkipDuplicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        //03.Modify the previous program to skip duplicates:
        //    n=4, k=2 -> (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)

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
                    GenValue(index + 1, arr, arr[0] + 1, end, sb);
                }
            }
        }

        private static void Print(int[] arr, StringBuilder sb)
        {
            sb.Append("(" + String.Join(" ", arr) + ")\n");
        }
    }
}
