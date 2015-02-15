using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//05.Write a method that calculates the number of workdays between today and 
//   given date, passed as parameter. Consider that workdays are all days from 
//   Monday to Friday except a fixed list of public holidays specified preliminary as array.


class Program
{
    static int WorkdaysFromNowToDate(DateTime date)
    {
        DateTime today = DateTime.Today;
        int days = 0;
        if (DateTime.Compare(today, date) < 0)
        {
            do
            {
                if (IsWorkingDay(today) && !IsHoliday(today))
                {
                    days++;
                }
                today = today.AddDays(1);
            } while (DateTime.Compare(today, date) <= 0);
        }
        else if (DateTime.Compare(today, date) > 0)
        {
            do
            {
                if (IsWorkingDay(date) && !IsHoliday(date))
                {
                    days++;
                }
                date = date.AddDays(1);
            } while (DateTime.Compare(date, today) <= 0);
        }
        else
        {
            days = 0;
        }
        return days;
    }

    static bool IsHoliday(DateTime date)
    {
        int year = date.Year;
        DateTime[] holidaysArray =
        {
            new DateTime(year, 1, 1),
            new DateTime(year, 3, 3),
            new DateTime(year, 5, 1),
            new DateTime(year, 5, 2),
            new DateTime(year, 5, 6),
            new DateTime(year, 5, 24),
            new DateTime(year, 9, 22),
            new DateTime(year, 12, 24),
            new DateTime(year, 12, 25),
            new DateTime(year, 12, 26),
            new DateTime(year, 12, 31)
        };
        for (int i = 0; i < holidaysArray.Length; i++)
        {
            if (DateTime.Equals(date, holidaysArray[i]))
            {
                return true;
            }
        }
        return false;
    }
 
    static bool IsWorkingDay(DateTime date)
    {
        return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
    }


    static void Main()
    {
        Console.Write("05.Input the date (yyyy.mm.dd): ");
        string stringDate = Console.ReadLine();
        DateTime date = DateTime.Parse(stringDate);
        int sumOfWorkdays = WorkdaysFromNowToDate(date);
        Console.WriteLine("Workdays between today and the given date: "+sumOfWorkdays);
    }
}