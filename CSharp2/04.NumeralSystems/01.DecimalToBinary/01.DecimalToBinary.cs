using System;
using System.Collections.Generic;

//01.Write a program to convert decimal numbers to their binary representation.
//   Test page http://www.cleavebooks.co.uk/scol/calnumba.htm


class DecimalToBinary
{
    static List<bool> DecimalToBinaryCalc(int n)
    {
        List<bool> number = new List<bool>();

        while (n>0)
        {
            if (n % 2 == 0)
            {
                number.Add(false);
            }
            else
            {
                number.Add(true);
            }
            n = n / 2;
        }
        number.Reverse();
        return number;
    }

    static void BoolPrinter(List<bool> number)    // Translates true/false to 1/0 and prints the list
    {
        foreach (bool element in number)
        {
            if (element == true) Console.Write("1");
            else if (element == false) Console.Write("0"); 
        }
    }

    static void Main()
    {
        Console.Write("01.Imput decimal number : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("The binary representation of your number is : ");
        BoolPrinter(DecimalToBinaryCalc(n));
        Console.WriteLine();
    }
}
