using System;

class OddOrEven
{
    //01.Write an expression that checks if given integer is odd or even.
    static void Main()
    {
        Console.WriteLine(" Input your number :");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine((n % 2 == 0) ? " The number {0} is Even" : " The number {0} is Odd", n);
    }
}

