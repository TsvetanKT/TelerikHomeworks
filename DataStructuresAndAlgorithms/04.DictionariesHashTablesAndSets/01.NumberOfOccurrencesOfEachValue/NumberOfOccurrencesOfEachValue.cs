namespace NumberOfOccurrencesOfEachValue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class NumberOfOccurrencesOfEachValue
    {
        /* 01. Write a program that counts in a given array of double values the number of occurrences of each value. Use Dictionary<TKey,TValue>.
                Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
                -2.5 -> 2 times
                3 -> 4 times
                4 -> 3 times
         */ 

        static void Main()
        {
            var array = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            IDictionary<double, int> numCount = new Dictionary<double, int>();
            CountNumbers(array, numCount);

        }

        private static void CountNumbers(double[] array, IDictionary<double, int> numCount)
        {
            foreach (double number in array)
            {
                int count = 1;
                if (numCount.ContainsKey(number))
                {
                    count = numCount[number] + 1;
                }
                numCount[number] = count;
            }

            foreach (var pair in numCount)
            {
                Console.WriteLine("{0} --> {1}", pair.Key, pair.Value);
            }
        }
    }
}
