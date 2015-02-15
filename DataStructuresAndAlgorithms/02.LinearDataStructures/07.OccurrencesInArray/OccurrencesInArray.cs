namespace OccurrencesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SumAndAvarageOfList;


    class OccurrencesInArray
    {
        //07. Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
        //  Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
        //  2 -> 2 times
        //  3 -> 4 times
        //  4 -> 3 times

        // TODO all tasks to the end if i have time 
        static void Main()
        {
            // Change limit to 1001 so the range becomes [0..1000]
            // I'm using  1..3 so the numbers occurs more oftenly.
            int limit = 4;
            var generatedList = SumAndAvarageOfList.RandomGeneratedList(15, 16, 0, limit);

            Console.WriteLine("The list is :");
            Console.WriteLine(string.Join(", ", generatedList) + "\n");

            var ocurrences = HowManyTimesEachOccurs(generatedList);
            Console.WriteLine("Occurrences:\n" + string.Join("\n", ocurrences) + "\n");

        }

        public static IEnumerable<object> HowManyTimesEachOccurs(List<int> input)
        {
            var numCount =
               from element in input
               group element by element into g
               select new { g.Key, Count = g.Count() };

            return numCount;
        }
    }
}
