namespace _05.Variations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        //05. Write a recursive program for generating and printing all ordered k-element
        //    subsets from n-element set (variations Vkn).
        //    Example: n=3, k=2, set = {hi, a, b} =>
        //    (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)

        static string[] set = { "hi", "a", "b" };

        public static void Main()
        {
            int k = 2;
            string[] arr = new string[k];
            int start = 0;
            StringBuilder sb = new StringBuilder();
            GenValue(0, arr, start, sb);
            Console.WriteLine(sb.ToString().Remove(sb.Length - 1, 1));
        }

        public static void GenValue(int index, string[] arr, int start, StringBuilder sb)
        {
            if (index >= arr.Length)
            {
                Print(arr, sb);
            }
            else
            {
                for (int i = start; i < set.Length; i++)
                {
                    arr[index] = set[i];
                    GenValue(index + 1, arr, start, sb);
                }
            }
        }
        private static void Print(string[] arr, StringBuilder sb)
        {
            sb.Append("(" + String.Join(" ", arr) + ")\n");
        }
    }
}
