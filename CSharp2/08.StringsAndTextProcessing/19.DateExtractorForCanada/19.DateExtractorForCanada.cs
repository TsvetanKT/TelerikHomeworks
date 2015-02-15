using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

//19.Write a program that extracts from a given text all dates that match the 
//   format DD.MM.YYYY. Display them in the standard date format for Canada.

class DateExtractorForCanada
{
    static void Main()
    {
        Console.WriteLine("19.Original text:");
        string text = "Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 20.01.2014, 19.19.2014 blq";
        Console.WriteLine(text);
        Console.WriteLine();
        DateTime date;
        Console.WriteLine("Founded dates that match the format DD.MM.YYYY :");
        foreach (Match item in Regex.Matches(text, @"\b\d{2}.\d{2}.\d{4}\b"))
        if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
        {
            Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
        }
    }
}
