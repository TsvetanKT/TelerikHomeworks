using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//02.Write a program that generates and prints to the console 10 random values in the range [100, 200].

namespace _02.TenRandoms
{
    class TenRandoms
    {
        static void Main()
        {
            Console.WriteLine("02.Ten random values in the range [100, 200]:");

            Random rand = new Random();
            for (int number = 1; number <= 10; number++)
            {
                int randomNumber = rand.Next(100,201); //100 included, 201 excluded
                Console.WriteLine("{0}: {1} ", number, randomNumber);
            }
        }
    }
}
