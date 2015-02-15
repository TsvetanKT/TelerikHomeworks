using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//01.Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

//http://en.wikipedia.org/wiki/Leap_year#Algorithm

namespace _01.LeapYearChecker
{
    class LeapYearChecker
    {
        static void Main()
        {
            Console.Write("01.Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Is {0} as Leap Year ?", year);
            Console.WriteLine("Using DateTime.IsLeapYear: " + DateTime.IsLeapYear(year));
            bool isItLeap = false;
            if (year % 400 == 0)
            {
                isItLeap = true;
            }
            else if (year % 100==0)
            {
                isItLeap = false;
            }
            else if (year % 4 == 0)
            {
                isItLeap = true;
            }
            else
            {
                isItLeap = false;
            }
            Console.WriteLine("Using calculation: "+ isItLeap);
        }
    }
}
