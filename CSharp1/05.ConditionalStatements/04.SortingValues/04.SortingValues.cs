using System;

class SortingValues
{
    static void Main()
    {
        //Sort 3 real values in descending order using nested if statements.

        Console.Write(" Number a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write(" Number b:");
        int b = int.Parse(Console.ReadLine());
        Console.Write(" Number c:");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (a > b)
        {
            if (a > c)
            {
                if (b > c)
                {
                    Console.WriteLine(" {0} , {1} , {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine(" {0} , {1} , {2}", a, c, b);
                }
            }
            else
            {
                Console.WriteLine(" {0} , {1} , {2}", c, a, b);
            }
        }
        else if (b > c)
        {
            if (a > c)
            {
                Console.WriteLine(" {0} , {1} , {2}", b, a, c);
            }
            else
            {
                Console.WriteLine(" {0} , {1} , {2}", b, c, a);
            }
        }
        else
        {
            Console.WriteLine(" {0} , {1} , {2}", c, b, a);
        }
    }
}
