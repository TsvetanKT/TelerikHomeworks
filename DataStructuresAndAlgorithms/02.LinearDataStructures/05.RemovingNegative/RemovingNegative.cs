namespace RemovingNegative
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SumAndAvarageOfList;

    class RemovingNegative
    {
        //05. Write a program that removes from given sequence all negative numbers.

        static void Main()
        {
            // from task 1
            var generatedList = SumAndAvarageOfList.RandomGeneratedList(15, 20, -10, 11);

            Console.WriteLine("The list is :");
            Console.WriteLine(string.Join(", ", generatedList) + "\n");

            var answer = RemovingNegatives(generatedList).Reverse();

            Console.WriteLine("With removed negatives :");
            Console.WriteLine(string.Join(", ", answer) + "\n");
        }

        public static Stack<int> RemovingNegatives(List<int> inputList)
        {
            // I'm using stack for quick adding. If needed, in the end can be changet - stack.ToList()
            Stack<int> stack = new Stack<int>();

            foreach (var element in inputList)
            {
                if (element >= 0)
                {
                    stack.Push(element);
                }
            }

            return stack;
        }
    }
}
