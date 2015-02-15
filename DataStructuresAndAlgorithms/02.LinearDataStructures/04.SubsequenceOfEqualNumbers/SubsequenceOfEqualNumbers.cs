namespace SubsequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SumAndAvarageOfList;

    class SubsequenceOfEqualNumbers
    {
        //04. Write a method that finds the longest subsequence of equal numbers in given List<int> 
        //  and returns the result as new List<int>. Write a program to test whether the method works correctly.

        static void Main()
        {
            // from task 1
            var generatedList = SumAndAvarageOfList.RandomGeneratedList(15, 20, 0, 4);

            Console.WriteLine("The list is :");
            Console.WriteLine(string.Join(", ", generatedList) + "\n");

            var answer = LongestSubsequenceOfEquals(generatedList);
            Console.WriteLine("Longest subsequence: " + string.Join(", ", answer) + "\n");


        }

        public static List<int> LongestSubsequenceOfEquals(List<int> inputList)
        {
            //TODO throw exceptions, check valid data input

            var answer = new List<int>();
            int counter = 0;
            int element = 0;
            int maxCount = 1;
            int bestElement = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                if ((i + 1) < inputList.Count)
                {
                    if (inputList[i] == inputList[i+1])
                    {
                        counter++;
                        element = inputList[i];
                        // If equal subsequences exixts, the answer will be the last of them
                        if (counter >= maxCount)
                        {
                            maxCount = counter;
                            bestElement = element;
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                }
            }

            for (int i = 0; i < maxCount + 1; i++)
            {
                answer.Add(bestElement);
            }

            return answer;
        }
    }
}
