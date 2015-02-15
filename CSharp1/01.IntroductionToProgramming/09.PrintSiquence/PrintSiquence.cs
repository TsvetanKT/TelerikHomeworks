using System;

class PrintSiquence
{
    //09.Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
    static void Main()
    {
        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("{0}, ", i);
            }
            else
            {
                if (i == 11)
                {
                    Console.WriteLine("{0} ", -i);
                }
                else
                {
                    Console.Write("{0}, ", -i);
                }
            }
        }
    }
}