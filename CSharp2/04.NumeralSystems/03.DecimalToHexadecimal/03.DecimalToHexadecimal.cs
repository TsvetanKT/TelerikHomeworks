using System;
using System.Collections.Generic;

//03.Write a program to convert decimal numbers to their hexadecimal representation.


public class DecimalToHexadecimal
{
     static List<char> DecimalToHexadecimalCalc(int n)
     {
         List<char> number = new List<char>();

         while (n > 0)
         {
             switch (n % 16)
             {
                 case 15: number.Add('F'); break;
                 case 14: number.Add('E'); break;
                 case 13: number.Add('D'); break;
                 case 12: number.Add('C'); break;
                 case 11: number.Add('B'); break;
                 case 10: number.Add('A'); break;
                 default: number.Add(Convert.ToChar((n % 16) + 48)); break; // Convert.ToChar(5+48)= '5'  
             }
             n = n / 16;
         }
         number.Reverse();
         return number;
     }

     static void HexPrinter(List<char> answer)    // printing the result
     {
         foreach (char element in answer)
         {
             Console.Write(element);
         }
     }

    static void Main()
    {
        Console.Write("03.Imput decimal number : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("The hexadecimal representation of your number is : ");
        HexPrinter(DecimalToHexadecimalCalc(n));
        Console.WriteLine();
    }
}
