using System;

//04.Write a program to convert hexadecimal numbers to their decimal representation.

class HexadecimalToDecimal
{

    private static int MyPow(int sqr)
    {
        return (1 << (sqr * 4));
    }

    static void Main()
    {
        Console.Write("04.Insert hexadecimal number (without 0x) : ");
        string startingInput = Console.ReadLine();
        string input = startingInput.ToUpper();
        int count = (input.Length - 1);
        int digit = 0;
        int answer = 0;

        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case 'A': digit = 10; break;
                case 'B': digit = 11; break;
                case 'C': digit = 12; break;
                case 'D': digit = 13; break;
                case 'E': digit = 14; break;
                case 'F': digit = 15; break;                    
                default: digit = int.Parse(Convert.ToString(input[i])); break;
            }

            answer += digit * MyPow(count);
            count--;
        }
        Console.WriteLine("The decimal representation : "+answer);
        Console.WriteLine();
    }
}