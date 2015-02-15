using System;

    class GCDOfTwoNumbers
    {
        static void Main()
        {
            //08.Write a program that calculates the greatest common divisor (GCD) of given two numbers.
            //Use the Euclidean algorithm (find it in Internet).

            Console.Write(" Insert the first number : ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write(" Insert the second number : ");
            int secondNum = int.Parse(Console.ReadLine());

            int remainder = 1;
            if (secondNum == 0)
            {
                Console.WriteLine(" The GCD is : {0}", firstNum);
            }
            else if (firstNum == 0)
            {
                Console.WriteLine(" The GCD is : {0}", secondNum);
            }
            else
            {
                while (remainder != 0)
                {
                    remainder = firstNum % secondNum;
                    firstNum = secondNum;
                    secondNum = remainder;
                }
                Console.WriteLine(" The GCD is : {0}", firstNum);
            }
        }
    }
