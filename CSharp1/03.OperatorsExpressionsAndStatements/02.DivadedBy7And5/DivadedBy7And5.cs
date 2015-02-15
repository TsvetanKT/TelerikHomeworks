using System;

class Program
{
    //02.Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
    static void Main()
    {
        Console.WriteLine(" Insert Number :");
        int n = int.Parse(Console.ReadLine());
        bool division = ((n % 7 == 0) && (n % 5 == 0));
        Console.WriteLine(" The number {0} can be divided by 7 and 5 in the same time ? -> {1}", n,division);
    }
}
