using System;

class QuotationsInTwoWays
{
    //08.Declare two string variables and assign them with following value:
    //      The "use" of quotations causes difficulties.
    //  Do the above in two different ways: with and without using quoted strings.
    static void Main()
    {
        Console.WriteLine(" First variant:");
        string firstWay = " The \"use\" of quotations causes difficulties.\n";
        Console.WriteLine(firstWay);

        Console.WriteLine(" Second variant:");
        string secondWay = @" The ""use"" of quotations causes difficulties.";
        Console.WriteLine(secondWay);

        Console.WriteLine();
    }
}