using System;

namespace zad5
{
    class FindingBit3
    {
        //05.Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
        static void Main()
        {
            Console.WriteLine(" Input number :");
            int n = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            Console.WriteLine(" Binary representation of {0} is {1}", n ,Convert.ToString(n, 2));
            Console.WriteLine(" The third bit is : {0}", ((n & mask) == mask) ? 1 : 0);
        }
    }
}
