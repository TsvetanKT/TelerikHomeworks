using System;

namespace TrapezoidArea
{
    class Program
    {
        //08.Write an expression that calculates trapezoid's area by given sides a and b and height h.
        static void Main()
        {
            Console.WriteLine(" Input a :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" Input b :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(" Input h :");
            int h = int.Parse(Console.ReadLine());
            float area = ((a + b) / (float)2) * h;
            Console.WriteLine(" Area = " + area);
        }
    }
}
