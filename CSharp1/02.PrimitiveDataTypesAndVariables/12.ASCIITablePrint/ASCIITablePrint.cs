using System;

class ASCIITablePrint
{
    //12.Find online more information about ASCII (American Standard Code for Information Interchange) 
    //  and write a program that prints the entire ASCII table of characters on the console.
    static void Main()
    {
        for (int character = 0; character < 255; character++)
        {
            char symbol = (char)character;
            Console.WriteLine(" {0} -> {1}", character, symbol);            
        }
    }
}