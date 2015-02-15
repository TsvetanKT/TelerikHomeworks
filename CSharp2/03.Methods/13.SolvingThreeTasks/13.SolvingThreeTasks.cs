using System;
using System.Text;

/*13.Write a program that can solve these tasks:
        - Reverses the digits of a number
        - Calculates the average of a sequence of integers
        - Solves a linear equation a * x + b = 0
     Create appropriate methods.
     Provide a simple text-based menu for the user to choose which task to solve.
     Validate the input data:
        - The decimal number should be non-negative
        - The sequence should not be empty
        - a should not be equal to 0   
 */

class SolvingThreeTasks
{
    static void ReverseDigit()
    {
        Console.WriteLine("Reversing the digits of a number");
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        StringBuilder reverseDigit = new StringBuilder();
        if (n >= 0)
        {
            while (n != 0)
            {
                int lastDigit = n % 10;
                reverseDigit.Append(lastDigit);
                int lastNum = n / 10;
                n = lastNum;
     
            }
            Console.Write("The number in reverse is: {0}", int.Parse(reverseDigit.ToString()));
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The input number can NOT be Negative!");
        }
        Console.WriteLine();
     
    }
     
    static void CalculateAvgSum()
    {
        string nStr = string.Empty;
        decimal n;
        string stop = ""; //hmm
        decimal counter = 0;
        decimal sum = 0;
        Console.WriteLine("Calculating the average of a sequence of integers");
        Console.WriteLine("Enter your sequence of numbers");
        Console.WriteLine("When you finish add an empty row");
        nStr = Console.ReadLine();
        if (nStr != string.Empty)
        {
            if (decimal.TryParse(nStr, out n))
            {
                counter++;
                sum = sum + n;
            }

            while ((nStr != "")&&(nStr != " "))
            {
                nStr = Console.ReadLine();
                if (nStr.Equals(stop, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                if (decimal.TryParse(nStr, out n))
                {
                    counter++;
                    sum = sum + n;
                }
            }
            decimal avgSum = sum / counter;
            Console.WriteLine("Average = {0:F2}", avgSum);
            Console.WriteLine();
        }
    }
     
    static void SolveLinearEq()
    {

        Console.WriteLine("Solving a linear equation a * x + b = 0");
        Console.Write("a=");
        decimal a = decimal.Parse(Console.ReadLine());
        if (a != 0)
        {
            Console.Write("b=");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal x = b / a;
            Console.WriteLine();
            Console.WriteLine("{0}x + ({1}) = 0",a,b);
            Console.WriteLine("x={0}", x);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Input 'a' can NOT be Zero!");
        }
     
    }
    static void PrintMenu()
    {
        Console.WriteLine("                      MENU:");
        Console.WriteLine();
        Console.WriteLine("- Input 1 - Reverses the digits of a number");
        Console.WriteLine("- Input 2 - Calculates the average of a sequence of integers");
        Console.WriteLine("- Input 3 - Solves a linear equation a * x + b = 0");
        Console.WriteLine("- Input 4 - End Program");
        Console.WriteLine();
        
        while (true)
        {
            Console.Write("Menu: ");
            string menu = Console.ReadLine();
            if (menu == "1")
            {
                ReverseDigit();
            }
            else if (menu == "2")
            {
                CalculateAvgSum();
            }
            else if (menu == "3")
            {
                SolveLinearEq();
            }
            else if (menu == "4")
            {
                Console.WriteLine("Bye Bye");
                return;
            }
            else
            {
                Console.WriteLine("Invalid MENU OPTION!");
            }           
        }      
    }
    static void Main()
    {
        PrintMenu();
    }
}

