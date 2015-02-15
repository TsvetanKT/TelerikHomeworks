
using System;

class GreatestFromFiveN
{
    static void Main()
    {
        // 07. Write a program that finds the greatest of given 5 variables.

        Console.WriteLine();
        Console.Write(" Enter the first number  : ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write(" Enter the second number : ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write(" Enter the third number  : ");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.Write(" Enter the fourth number : ");
        double fourthNumber = double.Parse(Console.ReadLine());
        Console.Write(" Enter the fifth number  : ");
        double fifthNumber = double.Parse(Console.ReadLine());

        double BiggestNumber = firstNumber;
        if (BiggestNumber < secondNumber)
        {
            BiggestNumber = secondNumber;
        }
        if (BiggestNumber < thirdNumber)
        {
            BiggestNumber = thirdNumber;
        }
        if (BiggestNumber < fourthNumber)
        {
            BiggestNumber = fourthNumber;
        }
        if (BiggestNumber < fifthNumber)
        {
            BiggestNumber = fifthNumber;
        }
        Console.WriteLine();
        Console.WriteLine(" The biggest number is: {0}", BiggestNumber);
    }
}
