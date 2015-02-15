using System;
using System.Text;

//04.Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//		Example: The target substring is "in". The text is as follows: The result is: 9.

/*      We are living in an yellow submarine. We don't have anything else. 
 *      Inside the submarine is very tight. So we are drinking all the day. 
 *      We will move out of it in 5 days.
 */

class SubstringCounter
{
    static void Main()
    {
        Console.Write("04.Target substring: ");
        string sub = Console.ReadLine();
        Console.WriteLine("Given text :");
        string input = @"We are living in an yellow submarine. We don't have anything else. 
Inside the submarine is very tight. So we are drinking all the day. 
We will move out of it in 5 days.";
        Console.WriteLine(input);
        string text = input.ToLower();  //Making the text and the searched substring a lower case.
        string lowerSub = sub.ToLower();

        bool exit = false;
        int counter = 0;
        int index = 0;
        while (exit == false)
        {
            if (text.IndexOf(sub, index) != -1) //When IndexOf returns -1 the while loop ends.
            {
                counter++;
                index = (text.IndexOf(sub, index) + 1); //The index = the last index + 1, so we are not inspecting the same element more than once.
            }
            else
            {
                exit = true;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The result is: " + counter);
    }
}

