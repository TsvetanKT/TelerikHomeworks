using System;

class QuadraticEquationABC
{
    static void Main()
    {
        //6.Write a program that enters the coefficients a, b and c of a quadratic equation
		//a*x2 + b*x + c = 0
		//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

        Console.WriteLine();
        Console.WriteLine(" Calculating the real roots of ax2 + bx + c = 0" );
        Console.WriteLine();
        Console.Write("Input a : ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Input b : ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Input c : ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine(" Not an quadratic equation !");
        }
        else
        {
            double discriminant = (b * b) - (4 * a * c);
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine(" The equation roots are:\n X1: {0}\n X2: {1}", x1, x2);
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine(" The equaltion has only one root: {0}", x);
            }
            else if (discriminant < 0)
            {
                Console.WriteLine(" This equations doesn't have a solution!");
            }
        }
    }
}