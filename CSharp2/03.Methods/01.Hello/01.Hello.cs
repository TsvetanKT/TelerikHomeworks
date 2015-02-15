using System;

//01.Write a method that asks the user for his name and
//   prints “Hello, <name>” (for example, “Hello, Peter!”). 
//   Write a program to test this method.


class Hello
{
    static void PrintHello(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        Console.Write("Enter your name : ");
        string input = Console.ReadLine();
        PrintHello(input);
    }
}

