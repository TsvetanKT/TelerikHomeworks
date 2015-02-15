using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//01.Write a program that reads an integer number and calculates and 
//   prints its square root. If the number is invalid or negative, print
//   "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

class InvalidInteger
{
    public static double Sqrt(double value)
    {
        if (value < 0)
        {
            throw new System.ArgumentOutOfRangeException("Sqrt can NOT handle negative numbers!");
        }
        else
        {
            return Math.Sqrt(value);
        }
    }

    static void Main()
    {
        Console.Write("01.Insert number: ");
        try
        {
            double n = int.Parse(Console.ReadLine());
            double result = Sqrt(n);
            Console.WriteLine(result);
        }
        catch (OverflowException over) 
        {
            Console.Error.WriteLine("Error1: Invalid number - " + over.Message);
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Error2: Invalid number");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine("Error3: Invalid number - " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Good bye !");
        }
    }
}