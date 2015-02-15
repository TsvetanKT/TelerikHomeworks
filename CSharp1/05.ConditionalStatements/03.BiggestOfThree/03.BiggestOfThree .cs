using System;

class BiggestOfThree 
{
    static void Main()
    {
        //03.Write a program that finds the biggest of three integers using nested if statements.

        Console.Write(" Input intriger a : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write(" Input intriger b : ");
        int b = int.Parse(Console.ReadLine());
        Console.Write(" Input intriger c : ");
        int c = int.Parse(Console.ReadLine());           
        Console.WriteLine();

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine(" The biggerst number is : {0}", a);
            }
            else
            {
                Console.WriteLine(" The biggerst number is : {0}", c);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine(" The biggerst number is : {0}", b);
            }
            else
            {
                Console.WriteLine(" The biggerst number is : {0}", c);
            }
                
        }
    }
}

