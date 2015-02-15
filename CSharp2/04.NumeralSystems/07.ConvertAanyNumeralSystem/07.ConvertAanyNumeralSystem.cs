using System;

//07.Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

class ConvertAanyNumeralSystem  //this program uses ASCII table 
{                                               
    static void Main()                          
    {                                          
        Console.Write("07.Input number to convert: ");
        string startingInput = Console.ReadLine();
        string input = startingInput.ToUpper();    //convert the string to upper case (a become A , A stays A)
        Console.Write("From numeral system with base: "); //works even with numeral systems bigger than 16 too
        int s = int.Parse(Console.ReadLine());
        Console.Write("To numeral system with base: ");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Answer: "+DecToAny(AnyToDec(input, s), d));
        Console.WriteLine();
    }

    static int AnyToDec(string number, int numeralBase)
    {
        int dec = 0;
        int count = 1;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            dec += GetNumber(number[i]) * count;
            count = count * numeralBase;
        }
        return dec;
    }

    static int GetNumber(char a)   //converting to decimal
    {
        if (a >= 'A')
        {
            return (int)(a - 'A' + 10);
        }
        else
        {
            return (int)(a - '0');
        }
    }

    static string DecToAny(int dec, int numeralBase)
    {
        string result = "";

        while (dec > 0)
        {
            result = GetString(dec % numeralBase) + result;
            dec /= numeralBase;
        }
        return result;
    }

    static string GetString(int a)
    {
        if (a >= 10)
        {
            return ((char)('A' - 10 + a)).ToString();
        }
        else
        {
            return ((char)('0' + a)).ToString();
        }
    }
}