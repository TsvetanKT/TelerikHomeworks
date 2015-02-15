using System;

namespace PointInCircle
{
    class Program
    {
        //06.Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
        static void Main()
        {          
            Console.WriteLine(" Input x :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(" Input y :");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(" Point ({0},{1}) is within a circle K(O, 5)? : {2}", x, y, (x * x + y * y) < 25);
        }
    }
}
