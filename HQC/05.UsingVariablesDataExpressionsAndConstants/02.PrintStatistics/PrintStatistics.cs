namespace PrintStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PrintStatisticsClass
    {
        public static void PrintStatistics(double[] arr, int count)
        {
            double maxValue = double.MinValue;
            double minValue = double.MaxValue;
            double allElementsSum = 0;

            // Only one for-loop is needed.
            for (int i = 0; i < count; i++) 
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }

                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }

                allElementsSum += arr[i];
            }

            double avarageValue = allElementsSum / count;

            Console.WriteLine("Element with maximal value: " + maxValue);
            Console.WriteLine("Element with minimal value: " + minValue);
            Console.WriteLine("Avarage value of the first " + count + " elements: " + avarageValue);
        }

        public static void Main()
        {
            double[] testArr = { 1, 2, 3, 4, 55, -66, 0.5 };

            PrintStatistics(testArr, testArr.Length);
        }
    }
}
