using System;

class FloatAndDouble
{
    //02.Which of the following values can be assigned to a variable of type float and which to a 
    //  variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
    static void Main()
    {
        double number1 = 34.567839023d;
        float number2 = 12.345f;
        double number3 = 8923.1234857f;
        float number4 = 3456.091f;

        Console.WriteLine(" {0} ; {1} ; {2} ; {3}\n", number1, number2, number3, number4);
    }
}
