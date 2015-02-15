namespace RemoveOccuringOddTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SumAndAvarageOfList;

    class RemoveOccuringOddTimes
    {
        //06. Write a program that removes from given sequence all numbers that occur odd number of times. Example:
        //    {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} -> {5, 3, 3, 5}

        static void Main()
        {
            // from task 1
            var generatedList = SumAndAvarageOfList.RandomGeneratedList(15, 16, 0, 5);

            Console.WriteLine("The list is :");
            Console.WriteLine(string.Join(", ", generatedList) + "\n");

            var answer = RemoveOddOccurrence(generatedList);

            Console.WriteLine("Without numbers that occur odd number of times:\n" + string.Join(", ", answer) + "\n");
        }

        public static List<int> RemoveOddOccurrence(List<int> input)
        {
            var numCount =
               from element in input
               group element by element into g
               select new { g.Key, Count = g.Count() };

            Console.WriteLine("Occurrences:\n" + string.Join("\n", numCount) + "\n");

            var oddOccurNumbers = new List<int>();

            foreach (var element in numCount)
            {
                if (element.Count % 2 != 0)
                {
                    oddOccurNumbers.Add(element.Key);
                }
            }

            bool isThisNumberOddlyOccuring = false;
            List<int> answer = new List<int>();

            foreach (var number in input)
            {
                // oddOccurNumbers haves just a few elements so we have lesser than O(n^2)
                foreach (var item in oddOccurNumbers)
                {
                    if (number == item)
                    {
                        isThisNumberOddlyOccuring = true;
                        break;
                    }
                }

                if (!isThisNumberOddlyOccuring)
                {
                    answer.Add(number);
                }

                isThisNumberOddlyOccuring = false;
            }

            return answer;
        }
    }
}
