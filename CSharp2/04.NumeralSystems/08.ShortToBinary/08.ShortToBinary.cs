using System;

//08.Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

class ShortToBinary
{
    static void Main()
    {
        Console.Write("08.Input a number of type short (from -32768 to 32767): ");
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine("Answer: "+ShortToBin(number));
    }
    static string ShortToBin(short number)
    {
        char[] bit = new char[16];
        short pos = 15;
        short i = 0;
        while (i < 16)  //checking every bit is it 1 or 0
        {
            if ((number & (1 << i)) != 0)
            {
                bit[pos] = '1';
            }
            else
            {
                bit[pos] = '0';
            }
            pos--;
            i++;
        }
        return new string(bit);
    }
}