using System;

namespace IsThirdDigitSeven
{
    class Program
    {
        //04.Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.
        static void Main()
        {
            Console.WriteLine(" Input number :");
            int n = int.Parse(Console.ReadLine());
            int temp = n / 100;
            temp %= 10;
            Console.WriteLine(temp == 7);
        }
    }
}
