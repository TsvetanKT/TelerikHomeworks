using System;

class ShowSignOfThreeNumbers
{
    static void Main()
    {
        //02.Write a program that shows the sign (+ or -) of the product of three real numbers
        //without calculating it. Use a sequence of if statements.

        Console.Write(" Please enter number a : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write(" Please enter number b : ");
        int b = int.Parse(Console.ReadLine());
        Console.Write(" Please enter number c : ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine();

        if ((a < 0 && b < 0 && c < 0) || (a < 0 ^ b < 0 ^ c < 0))

        {
            Console.WriteLine(" The sign of the product is -");
        }

        else

        {
            Console.WriteLine(" The sign of the product is +");
        }

        Console.WriteLine();            
    }
}