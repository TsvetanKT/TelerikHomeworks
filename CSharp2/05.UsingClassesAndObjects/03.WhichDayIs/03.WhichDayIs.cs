using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//03.Write a program that prints to the console which day of the week is today. Use System.DateTime.

class WhichDayIs
{
    static void Main()
    {
        Console.WriteLine("03.The day of the week for today: {0:d} is {1}.", DateTime.Now, DateTime.Now.DayOfWeek);
    }
}
