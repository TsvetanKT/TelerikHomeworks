using System;

namespace ExchangeChosenBits
{
    class Program
    {
        //14.* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
        static uint swapBits(byte positionOne, byte positionTwo, uint number)
        {
            uint one = 1;
            uint maskOne = one << positionOne;
            uint maskTwo = one << positionTwo;
            byte posOneInfo = ((number & maskOne) == maskOne) ? (byte)1 : (byte)0;
            byte posTwoInfo = ((number & maskTwo) == maskTwo) ? (byte)1 : (byte)0;

            number = posTwoInfo == 0 ? number & ~maskOne : number | maskOne;
            number = posOneInfo == 0 ? number & ~maskTwo : number | maskTwo;

            return number;
        }
        static void Main()
        {
            Console.WriteLine(" Enter number:");
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine(" Enter bit member from group one (p):");
            byte p = byte.Parse(Console.ReadLine());
            Console.WriteLine(" Enter spread (k):");
            byte k = byte.Parse(Console.ReadLine());
            Console.WriteLine(" Enter bit member from group two (q):");
            byte q = byte.Parse(Console.ReadLine());

            for (byte i = p, j = q; i <= p + k - 1; i++, j++)
            {
                number = swapBits(i, j, number);
            }

            Console.WriteLine(" Result:");
            Console.WriteLine(number);
        }
    }
}
