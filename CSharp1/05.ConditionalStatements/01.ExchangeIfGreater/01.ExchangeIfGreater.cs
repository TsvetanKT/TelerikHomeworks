using System;

class ExchangeIfGreater
{
    static void Main()
    {
        // 01.Write an if statement that examines two integer variables and exchanges 
        // their values if the first one is greater than the second one.

        Console.Write(" Input x variable : ");
        int x = int.Parse(Console.ReadLine());
        Console.Write(" Input y variable : ");
        int y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            x = x + y; // Exchanging values
            y = x - y;
            x = x - y;
        }
        Console.WriteLine();
        Console.WriteLine(" x = {0}\n y = {1}\n",x,y);
    }
}
