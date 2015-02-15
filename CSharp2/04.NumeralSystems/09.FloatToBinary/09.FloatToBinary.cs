using System;
using System.Threading;
using System.Globalization;

//09.* Write a program that shows the internal binary representation of given 32-bit 
//   signed floating-point number in IEEE 754 format (the C# type float). 
//   Example: -27,25 -> sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.


class FloatToBinary
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;  //globalization for "," and "."
        Console.Write("09.Input a number of type float: ");
        float number = float.Parse(Console.ReadLine());
        long convertBitsOfNumber = BitConverter.DoubleToInt64Bits(number);
        long mask = 1;
        long sign = 0;
        string binaryRepresentation = "";
        string exponent;
        string mantisa;

        sign = ((convertBitsOfNumber >> 63) & mask);
        convertBitsOfNumber = (convertBitsOfNumber & (~(mask << 63)));

        while (convertBitsOfNumber != 0)  //taking all bits from the number
        {
            binaryRepresentation = (convertBitsOfNumber % 2) + binaryRepresentation;
            convertBitsOfNumber /= 2;
        }

        if (number > -2.0f && number < 2.0f)  //f for float
        {
            exponent = "0";

            exponent += binaryRepresentation.Substring(3, 7);

            mantisa = binaryRepresentation.Substring(10, 23);
        }
        else
        {
            exponent = binaryRepresentation.Substring(0, 1);
            exponent += binaryRepresentation.Substring(4, 7);
            mantisa = binaryRepresentation.Substring(11, 23);
        }
        Console.Write("Answer: ");
        Console.Write(sign + " ");
        Console.Write(exponent + " ");
        Console.WriteLine(mantisa);
    }
}