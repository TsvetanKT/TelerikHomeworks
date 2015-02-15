using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

//17.Write a program that reads a date and time given in the format: day.month.year
//   hour:minute:second and prints the date and time after 6 hours and 30 minutes 
//   (in the same format) along with the day of week in Bulgarian.

class DateAndTimeInBulgarian
{
    static void Main()
    {
        Console.Write("17.Enter date(d.MM.yyyy HH:mm:ss): ");
        //string strDate = Console.ReadLine();
        string strDate = "20.01.2014 12:23:44";
        Console.WriteLine(strDate);
        DateTime date = DateTime.ParseExact(strDate, "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        DateTime newDate = date.AddHours(6.5);
        Console.WriteLine("6.5 hours after your date will be: {0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
    }
}