using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

//11.Write a program that reads a number and prints it as a decimal number, hexadecimal
//   number, percentage and in scientific notation. Format the output aligned right in 15 symbols.

class FormatToFifteenSymbols
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =CultureInfo.InvariantCulture; //for problems with , and .
        Console.Write("11.Enter a number: ");
        decimal num = decimal.Parse(Console.ReadLine());

        string toDec = String.Format("{0,15}: decimal", num);
        string toHex = String.Format("{0,15}: hex presentation of the int part", Convert.ToString((int)num, 16).ToUpper());
        string toPercentage = String.Format("{0,15:P}: as percentage", num);
        string toScient = String.Format("{0,15:E7}: as scientific notation", num);

        string finalStr = String.Format("{0}\n{1}\n{2}\n{3}", toDec, toHex, toPercentage, toScient);
        Console.WriteLine(finalStr);
    }
}