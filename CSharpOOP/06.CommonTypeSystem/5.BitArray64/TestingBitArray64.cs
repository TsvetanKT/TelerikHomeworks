//05.Define a class BitArray64 to hold 64 bit values inside an ulong value. 
//   Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace BitArray64
{
    using System;
    using System.Text;
    class TestingBitArray64
    {
        static void Print (BitArray64 array)
        {          
            Console.WriteLine("Bit Array:");
            Console.WriteLine(array.Bits);
            Console.WriteLine("Ulong value = " + array.UlongValue);
            Console.WriteLine();
        }
        static void Main()
        {
            Console.WriteLine("05.Testing BitArray64\n");
            var firstArray = new BitArray64();

            firstArray.UlongValue = 1;
            Print(firstArray);

            Console.WriteLine("Foreach test: add 1 to all bit elements as ints");
            foreach (var item in firstArray)
            {
                // Just printing the result, not changing the array bits (cuz of the "2")
                Console.Write(item + 1);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Testing []");
            Console.WriteLine("Changing element [0] to 1:");
            firstArray[0] = 1;
            Print(firstArray);

            Console.WriteLine("Changing element [2] to 1:");
            firstArray[2] = 1;
            Print(firstArray);

            Console.WriteLine("Testing \"==\" and \"!=\"");
            Console.WriteLine("New BitArray64 ");
            var secondrArray = new BitArray64();
            secondrArray.UlongValue = ulong.MaxValue;
            Print(secondrArray);

            Console.WriteLine("firstArray == secondrArray : " + (firstArray == secondrArray));
            Console.WriteLine("firstArray != secondrArray : " + (firstArray != secondrArray));

            Console.WriteLine();
        }       
    }
}
