using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//02.Write a method ReadNumber(int start, int end) that enters an integer 
//   number in given range [start…end]. If an invalid number or non-number 
//   text is entered, the method should throw an exception. Using this 
//   method write a program that enters 10 numbers:
//      a1, a2, … a10, such that 1 < a1 < … < a10 < 100
			
class MethodReadNumber
{
    static int ReadNumber(int start, int end)
    {
        int n = int.Parse(Console.ReadLine());

        if (!(start < n && n < end))
        {
            throw new ArgumentOutOfRangeException();
        }
        return n;
    }

    static void Main()
    {
        int min = 1, max = 100; // my range
        Console.WriteLine("02.Insert 10 numbers ( 1 < a1 <...< a10 < 100 ):");
        try
        {
            for (int i = 1; i < 11; i++)
            {
                Console.Write("a{0}= ",i);
                min = ReadNumber(min, max);
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Input Error. 1 < a1 <...< a10 < 100 ");
        }
        catch (FormatException) // if the input is not a number
        {
            Console.WriteLine("Input Error. The Format of your number is wrong. Acceptable are only Int32");
        }

    }
}