namespace SortList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SumAndAvarageOfList;

    class SortList
    {
        // 03. Write a program that reads a sequence of integers (List<int>) ending with an 
        //  empty line and sorts them in an increasing order.

        static void Main()
        {
            // from task 1
            var generatedList = SumAndAvarageOfList.RandomGeneratedList(5, 12, 0, 100);

            Console.WriteLine("The list is :");
            Console.WriteLine(string.Join(", ", generatedList) + "\n");

            // This is too easy
            //generatedList.Sort();

            generatedList = generatedList.OrderBy(e => e).ToList();

            Console.WriteLine("Sorted: " + string.Join(", ", generatedList) + "\n");
        }
    }
}
