using System;

class Program
{
    //03.Write an expression that calculates rectangle’s area by given width and height.
    static void Main()
    {
        Console.WriteLine(" Input width :");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(" Input height :");
        int h = int.Parse(Console.ReadLine());
        Console.WriteLine(" Rectangle’s area is {0}", (a * h));
    }
}
