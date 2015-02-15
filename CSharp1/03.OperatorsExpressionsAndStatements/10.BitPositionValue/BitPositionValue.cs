using System;

namespace BitPositionValue
{
    class Program
    {
        //10.Write a boolean expression that returns if the bit at position p (counting from 0) in a given 
        //  integer number v has value of 1. Example: v=5; p=1 -> false.
        static void Main()
        {         
            Console.WriteLine(" Input v (intriger number) :");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine(" Input p (position of bit) :");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine(" Binary representation of {0} is {1} \n", v, Convert.ToString(v, 2));
            int mask = 1 << p;
            bool result = ((v & mask) == mask);
            Console.WriteLine(" Bit at position {0} is 1 ? -> {1}", p, result);
        }
    }
}