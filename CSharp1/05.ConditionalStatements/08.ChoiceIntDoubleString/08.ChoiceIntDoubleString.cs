using System;

class ChoiceIntDoubleString
{
    static void Main()
    {
        // Write a program that, depending on the user's choice inputs int, double or string variable.
        // If the variable is integer or double, increases it with 1. If the variable is string, 
        // appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.

        Console.WriteLine(" Input :\n\n 1 for int\n 2 for double\n 3 for string\n");
        byte choice = byte.Parse(Console.ReadLine());
        Console.WriteLine();
        switch (choice)
        {
            case 1:
                Console.Write(" You selected 1 for int. Input number : ");
                int intChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(" The answer is : {0} + 1 = {1}\n", intChoice, intChoice + 1);
                break;
            case 2:
                Console.Write(" You selected 2 for double. Input number : ");
                double doubleChoice = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(" The answer is : {0} + 1 = {1}\n", doubleChoice, doubleChoice + 1);
                break;
            case 3:
                Console.Write(" You selected 3 for string. Input text : ");
                string stringChoice = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine(" The answer is : {0} + * = {1}\n", stringChoice, stringChoice + "*");
                break;
            default: Console.WriteLine(" ERROR !");
                break;
        }
    }
}