using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;


//16.Write a program that reads two dates in the format: day.month.year and 
//   calculates the number of days between them. Example:
//   Enter the first date: 27.02.2006
//   Enter the second date: 3.03.2006
//   Distance: 4 days

class DaysBetweenTwoDates
{
    static void Main()
    {   
        Console.Write("16.Input starting date (d.MM.yyyy): ");
        string start = Console.ReadLine();
        Console.Write("        Input end date (d.MM.yyyy): ");
        string end = Console.ReadLine();
        DateTime startDate = DateTime.ParseExact(start, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(end, "d.MM.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Number of days in between: "+(endDate - startDate).TotalDays);
    }
}

