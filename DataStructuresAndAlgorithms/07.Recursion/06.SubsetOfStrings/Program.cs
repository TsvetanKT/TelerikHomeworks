namespace _06.SubsetOfStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        //06. Write a program for generating and printing all subsets of k strings from given set of strings.
        //    Example: s = {test, rock, fun}, k=2
        //    (test rock),  (test fun),  (rock fun)

        static string[] set = { "test", "rock", "fun" };

        static void Main()
        {
            int k = 2;
            int[] arr = new int[k];
            int start = 0;
            StringBuilder sb = new StringBuilder();
            GenValue(0, arr, start, sb);
            Console.WriteLine(sb.ToString().Remove(sb.Length - 2, 2));
        }

        static void GenValue(int index, int[] arr, int start, StringBuilder sb)
        {
            if (index >= arr.Length)
            {
                Print(arr, sb);
            }
            else
            {
                for (int i = start; i <= set.Length - 1; i++)
                {
                    arr[index] = i;
                    GenValue(index + 1, arr, arr[0] + 1, sb);
                }
            }
        }

        private static void Print(int[] arr, StringBuilder sb)
        {
            sb.Append("(");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    sb.Append(set[arr[i]] + " ");
                }
                else
                {
                    sb.Append(set[arr[i]]);
                }
            }

            sb.Append(") \n");
        }
    }
}
