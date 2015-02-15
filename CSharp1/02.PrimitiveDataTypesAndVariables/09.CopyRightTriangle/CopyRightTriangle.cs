using System;
using System.Text;

class CopyRightTriangle
{
    //09.Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows 
    //  Character Map to find the Unicode code of the © symbol. Note: the © 
    //  symbol may be displayed incorrectly.
    static void Main()
    {
        Console.Write (" Triangle of copyright symbols :\n\n");

        Console.OutputEncoding = Encoding.UTF8;
        char copyRightSymbol = '\u00A9';
        int rows = 3;
        int columns = 7;
        int character = 1;
        for (int i = 0; i < rows; i++)
        {
            for (int blankSpace = 0; blankSpace < columns - i; blankSpace++)
            {
                Console.Write("  ");
            }
            for (int symbol = 0; symbol < character; symbol++)
            {
                Console.Write(copyRightSymbol);
            }
            character += 2; 

         Console.WriteLine();
        }
    }
}