using System;
using System.Text;

//03.Write a program to check if in a given expression the brackets are put correctly.
//   Example of correct expression: ((a+b)/5-d).
//   Example of incorrect expression: )(a+b)).

class ExpressionChecker
{
    static void Main()
    {
        Console.WriteLine("03.Input expression: ");
        string str = Console.ReadLine();
        bool correctness = true;
        int counter = 0;
        int index = str.IndexOf("(");

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '(')
            {
                counter++;
            }
            else if (str[i] == ')')
            {
                counter--;
            }
            //If we have brackets with nothing between them: Example (())  = Incorrect
            if (i < (str.Length - 1))
            {
                if ((str[i] == '(') && (str[i + 1] == ')'))
                {
                    correctness = false;
                }
            }
            //There shoud be no moment when we have more ')' than '('
            if (counter < 0)
            {
                correctness = false;
            }
        }
        //The total number of '(' must be = to ')'
        if (counter != 0)
        {
            correctness = false;
        }
        if (correctness == true)
        {
            Console.WriteLine("Correct expression.");
        }
        else
        {
            Console.WriteLine("Incorrect expression.");
        }
    }
}
