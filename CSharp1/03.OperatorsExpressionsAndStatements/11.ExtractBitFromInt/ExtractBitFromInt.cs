using System;

namespace ExtractBitFromInt
{
    class Program
    {
        //11.Write an expression that extracts from a given integer i the value of a given bit number b. 
        //  Example: i=5; b=2  value=1.
        static void Main()
        {        
            Console.WriteLine(" Input i (intriger number) :");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(" Input b (bit number) :");
            int b = int.Parse(Console.ReadLine());
            int mask = 1 << b;
            Console.WriteLine(" Result :");
            Console.WriteLine((i & mask) == mask ? 1 : 0);
        }
    }
}
