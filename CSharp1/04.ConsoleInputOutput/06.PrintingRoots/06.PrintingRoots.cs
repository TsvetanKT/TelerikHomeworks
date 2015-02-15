using System;

class PrintingRoots
{
    static void Main()
    {
        Console.WriteLine("06.Write a program that reads the coefficients a, b and c of a");
        Console.WriteLine("quadratic equation ax2+bx+c=0 and solves it (prints its real roots).");
        Console.WriteLine();
        Console.Write(" Input a : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write(" Input b : ");
        int b = int.Parse(Console.ReadLine());
        Console.Write(" Input c : ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine(" ({0})x^2 + ({1})x + ({2}) = 0", a, b, c);
        double D = (b * b) - (4.0 * a * c);
        Console.WriteLine(D);
        
        
        if (D < 0)
        {
            Console.WriteLine(" No real roots !");
        }
        else
        {
            if (D == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine(" One root = {0}", x);
            }
            else
            {
                double x1 = ((-b) + Math.Sqrt(D)) / 2 * a;
                double x2 = ((-b) - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine(" Two roots x1={0} and x2={1}", x1, x2);
            }
        }
    }
}