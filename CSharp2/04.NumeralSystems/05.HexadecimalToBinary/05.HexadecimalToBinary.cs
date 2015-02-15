using System;

//05.Write a program to convert hexadecimal numbers to binary numbers (directly).

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("05.Insert hexadecimal number (without 0x) : ");
        string startingInput = Console.ReadLine();
        string input = startingInput.ToUpper();
        HexToBinaryConvertor(input);
    }
    static void HexToBinaryConvertor(string input)
    {
        int len = input.Length;
        int binary = 0;
        int count = 0;
        for (int i = len - 1; i >= 0; i--, count++)
        {
            switch (input[i])
            {
                case 'A': binary = binary | (10 << 4 * count); break;
                case 'B': binary = binary | (11 << 4 * count); break;
                case 'C': binary = binary | (12 << 4 * count); break;
                case 'D': binary = binary | (13 << 4 * count); break;
                case 'E': binary = binary | (14 << 4 * count); break;
                case 'F': binary = binary | (15 << 4 * count); break;
                default: binary = binary | ((input[i] - 48) << 4 * count); break;
            }
        }
        Console.WriteLine("The binary representation : " + Convert.ToString(binary, 2));
    }
}