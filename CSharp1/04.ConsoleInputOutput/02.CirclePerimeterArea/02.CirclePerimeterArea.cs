using System;

class CirclePerimeterArea
{
    static void Main()
    {
        Console.WriteLine("02.Write a program that reads the radius r of a circle and prints its perimeter and area.");
        Console.WriteLine();
        Console.Write(" Input radius : ");
        int r = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("   S = {0} and P = {1}", (Math.PI) * r * r, 2 * (Math.PI) * r);
    }
}

