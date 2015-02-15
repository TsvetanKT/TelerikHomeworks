using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//06.You are given a sequence of positive integer values written into a string, separated by spaces. 
//   Write a function that reads these values from given string and calculates their sum. Example:
//		string = "43 68 9 23 318" -> result = 461


    class SequenceOfIntegers
    {
        static void Main()
        {
            Console.WriteLine("06.Input sequence of positive integer values:");
            string input = Console.ReadLine();
            input = input.Trim(); //removes spaces if exist on the first or last place in the array (Example: "  1 3" == "1 3")
            int sum = 0;
            string[] numbers = input.Split(' ');  // spliting the array where char ' ' is found
            for (int i = 0; i < numbers.Length; i++)
            {
                int current = int.Parse(numbers[i].Trim());
                sum = sum + current ;
                if (i < (numbers.Length-1))
                {
                    Console.Write(current + " + ");
                }
                else
                {
                    Console.Write(current + " = ");
                }              
            }
            Console.WriteLine(sum);
        }
    }
