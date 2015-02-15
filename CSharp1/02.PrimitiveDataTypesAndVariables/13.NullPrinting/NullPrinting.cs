using System;

class NullPrinting
{
    //13.Create a program that assigns null values to an integer and to double variables. Try to print 
    //  them on the console, try to add some values or the null literal to them and see the result.
    static void Main()
    {
        int? isNullInteger = null;
        Console.WriteLine(" This is the integer with null value -> {0}", isNullInteger);
        isNullInteger = 2;
        Console.WriteLine(" This is the integer with value 2    -> {0}", isNullInteger);

        double? isNullDouble = null;
        Console.WriteLine(" This is the double with null value  -> {0}", isNullDouble);
        isNullDouble = 5; 
        Console.WriteLine(" This is the integer with value 5    -> {0}", isNullDouble);
        Console.WriteLine();
    }
}