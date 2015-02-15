using System;


class SumOfSubset
{
    static void Main()
    {
        // 09. We are given 5 integer numbers. Write a program that checks 
        // if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 -> 1+1-2=0.

        Console.Write(" Input values for the five intrigers : ");
        Console.WriteLine();
        Console.Write(" a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write(" b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write(" c = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write(" d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write(" e = ");
        int e = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int errorCount = 0 ;

        // The syntax of if-else statement is preferably be in several lines with { and }, but 
        // in this case " If (expression) statement1; else statement2; " looks more readeble.

        if (a + b == 0) Console.WriteLine(" a + b = 0  ->  ({0}) + ({1}) = 0", a, b); else errorCount = errorCount + 1;
        if (a + c == 0) Console.WriteLine(" a + c = 0  ->  ({0}) + ({1}) = 0", a, c); else errorCount = errorCount + 1;
        if (a + d == 0) Console.WriteLine(" a + d = 0  ->  ({0}) + ({1}) = 0", a, d); else errorCount = errorCount + 1;
        if (a + e == 0) Console.WriteLine(" a + e = 0  ->  ({0}) + ({1}) = 0", a, e); else errorCount = errorCount + 1;
        if (b + c == 0) Console.WriteLine(" b + c = 0  ->  ({0}) + ({1}) = 0", b, c); else errorCount = errorCount + 1;
        if (b + d == 0) Console.WriteLine(" b + d = 0  ->  ({0}) + ({1}) = 0", b, d); else errorCount = errorCount + 1;
        if (b + e == 0) Console.WriteLine(" b + e = 0  ->  ({0}) + ({1}) = 0", b, e); else errorCount = errorCount + 1;
        if (c + d == 0) Console.WriteLine(" c + d = 0  ->  ({0}) + ({1}) = 0", c, d); else errorCount = errorCount + 1;
        if (c + e == 0) Console.WriteLine(" c + e = 0  ->  ({0}) + ({1}) = 0", c, e); else errorCount = errorCount + 1;
        if (d + e == 0) Console.WriteLine(" d + e = 0  ->  ({0}) + ({1}) = 0", d, e); else errorCount = errorCount + 1;
        if (a + b + c == 0) Console.WriteLine(" a + b + c = 0  ->  ({0}) + ({1}) + ({2}) = 0", a, b, c); else errorCount = errorCount + 1;
        if (a + b + d == 0) Console.WriteLine(" a + b + d = 0  ->  ({0}) + ({1}) + ({2}) = 0", a, b, d); else errorCount = errorCount + 1;
        if (a + b + e == 0) Console.WriteLine(" a + b + e = 0  ->  ({0}) + ({1}) + ({2}) = 0", a, b, e); else errorCount = errorCount + 1;
        if (a + c + d == 0) Console.WriteLine(" a + c + d = 0  ->  ({0}) + ({1}) + ({2}) = 0", a, c, d); else errorCount = errorCount + 1;
        if (a + c + e == 0) Console.WriteLine(" a + c + e = 0  ->  ({0}) + ({1}) + ({2}) = 0", a, c, e); else errorCount = errorCount + 1;
        if (a + d + e == 0) Console.WriteLine(" a + d + e = 0  ->  ({0}) + ({1}) + ({2}) = 0", a, d, e); else errorCount = errorCount + 1;
        if (b + c + d == 0) Console.WriteLine(" b + c + d = 0  ->  ({0}) + ({1}) + ({2}) = 0", b, c, d); else errorCount = errorCount + 1;
        if (b + c + e == 0) Console.WriteLine(" b + c + e = 0  ->  ({0}) + ({1}) + ({2}) = 0", b, c, e); else errorCount = errorCount + 1;
        if (b + d + e == 0) Console.WriteLine(" b + d + e = 0  ->  ({0}) + ({1}) + ({2}) = 0", b, d, e); else errorCount = errorCount + 1;
        if (c + d + e == 0) Console.WriteLine(" c + d + e = 0  ->  ({0}) + ({1}) + ({2}) = 0", c, d, e); else errorCount = errorCount + 1;
        if (a + b + c + d == 0) Console.WriteLine(" a + b + c + d = 0  ->  ({0}) + ({1}) + ({2}) + ({3}) = 0", a, b, c, d); else errorCount = errorCount + 1;
        if (a + b + c + e == 0) Console.WriteLine(" a + b + c + e = 0  ->  ({0}) + ({1}) + ({2}) + ({3}) = 0", a, b, c, e); else errorCount = errorCount + 1;
        if (a + b + d + e == 0) Console.WriteLine(" a + b + d + e = 0  ->  ({0}) + ({1}) + ({2}) + ({3}) = 0", a, b, d, e); else errorCount = errorCount + 1;
        if (a + c + d + e == 0) Console.WriteLine(" a + c + d + e = 0  ->  ({0}) + ({1}) + ({2}) + ({3}) = 0", a, c, d, e); else errorCount = errorCount + 1;
        if (b + c + d + e == 0) Console.WriteLine(" b + c + d + e = 0  ->  ({0}) + ({1}) + ({2}) + ({3}) = 0", b, c, d, e); else errorCount = errorCount + 1;

        Console.WriteLine();

        if (errorCount == 25)
        {
            Console.WriteLine(" There is no sum of subsets that is equal to 0 .");
        }
        else
        {
            Console.WriteLine(" Different sums of subsets equals to zero : {0}", 25 - errorCount);
        }
        Console.WriteLine();
    }
}

