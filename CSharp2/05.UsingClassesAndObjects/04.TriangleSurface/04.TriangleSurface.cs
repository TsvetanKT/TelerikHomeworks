using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

//04.Write methods that calculate the surface of a triangle by given:
//   Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

namespace _04.TriangleSurface
{
    class TriangleSurface
    {
        static void SideAndAltitude()
        {
            Console.Write("Enter side lenght: ");
            decimal side=decimal.Parse(Console.ReadLine());
            Console.Write("Enter altitude to that side: ");
            decimal altitude=decimal.Parse(Console.ReadLine());
            decimal answer = (side*altitude)/2;       //(a*ha)/2
            Console.WriteLine("The surface of a triangle is: " + answer);
        }

        static void ThreeSides()
        {
            Console.Write("Enter side a: ");
            decimal sideA=decimal.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            decimal sideB=decimal.Parse(Console.ReadLine());
            Console.Write("Enter side c: ");
            decimal sideC=decimal.Parse(Console.ReadLine());
            decimal answer =(sideA+sideB+sideC)/2;     //(a+b+c)/2
            Console.WriteLine("The surface of a triangle is: " + answer);
        }

        static void SidesAndAngle ()
        {
            Console.Write("Enter side one: ");
            decimal sideA=decimal.Parse(Console.ReadLine());
            Console.Write("Enter side two: ");
            decimal sideB=decimal.Parse(Console.ReadLine());
            Console.Write("Enter angle: ");
            double angle=double.Parse(Console.ReadLine());
            decimal answer =(sideA+sideB)* (decimal)Math.Sin(angle) /2;  // 1/2*a*b*SinC
            Console.WriteLine("The surface of a triangle is: "+answer);
        }

        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("04.Triangle surface calculator\n");
            Console.WriteLine("1-Side and an altitude\n2-Three sides\n3-Two sides and an angle between them\n4-Exit program\n");
            while (true)
            {
                Console.Write("Enter your choice (1/2/3/4): ");
                string choice =Console.ReadLine();
                if (choice == "1")
                {
                    SideAndAltitude();
                }
                else if (choice == "2")
                {
                    ThreeSides();
                }
                else if (choice == "3")
                {
                    SidesAndAngle();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Exit");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input !");
                }
            }
        }
    }
}
