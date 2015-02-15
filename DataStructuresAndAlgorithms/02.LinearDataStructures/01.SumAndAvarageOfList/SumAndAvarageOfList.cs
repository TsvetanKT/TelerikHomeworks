namespace SumAndAvarageOfList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumAndAvarageOfList
    {
        //01. Write a program that reads from the console a sequence of positive integer numbers. 
        //  The sequence ends when empty line is entered. Calculate and print the sum and average of 
        //  the elements of the sequence. Keep the sequence in List<int>.

        static void Main()
        {
            // Manual input is annoying, so i use random.
            var generatedList = RandomGeneratedList(3, 9, 0, 10);

            Console.WriteLine("The list is :");
            Console.WriteLine(string.Join(", ", generatedList));

            int sum = 0;

            foreach (var element in generatedList)
            {
                sum += element;
            }

            double avarage = (double)sum / generatedList.Count;

            Console.WriteLine("\nSum: {0}\nAvarage: {1}\n", sum, avarage);
        }

        public static List<int> RandomGeneratedList(int listMin, int listMax, int min, int max)
        {
            Random random = new Random();
            int randomLenght = random.Next(listMin, listMax);
            var generatedList = new List<int>();

            for (int i = 0; i < randomLenght; i++)
            {
                int value = random.Next(min, max);
                generatedList.Add(value);
            }

            return generatedList;
        }
    }
}
