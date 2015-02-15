using System;

//11.Write a method that adds two polynomials. Represent them as arrays of 
//   their coefficients as in the example below:
//   x2 + 5 = 1x2 + 0x + 5 -> 5,0,1
//12.Extend the program to support also subtraction and multiplication of polynomials.


class AddingPolynomials
{
    private static int GetPolynomialSize(string p)
    {
        if (p == "first")
        {
            return 3;
        }
        if (p == "second")
        {
            return 3;
        }
        return 0;
    }

    static int[] PolynomialElements(int n, string p)
    {
        int[] array = new int[n];
        if (p == "first")
        {
            array[0] = -17;    //Imputing array A
            array[1] = 0;
            array[2] = 6;
        }
        if (p == "second")
        {
            array[0] = 4;      //Imputing array B
            array[1] = -8;
            array[2] = 13;
        }
        return array;
    }

    static int[] SumOfPolynomials(int[] polyA, int[] polyB)
    {
        int[] polyC = new int[Math.Max(polyA.Length, polyB.Length)];
        for (int i = polyC.Length - 1; i >= 0; i--)
        {
            if (i < polyA.Length && i < polyB.Length)
            {
                polyC[i] = polyA[i] + polyB[i];
            }
            else if (i < polyA.Length)
            {
                polyC[i] = polyA[i];
            }
            else
            {
                polyC[i] = polyB[i];
            }
        }
        return polyC;
    }

    static int[] BeginingPolynomials(int[] polyA, int[] polyB)
    {
        int[] polyC = new int[Math.Max(polyA.Length, polyB.Length)];
        for (int i = polyC.Length - 1; i >= 0; i--)
        {
            if (i < polyA.Length && i < polyB.Length)
            {
                polyC[i] = polyA[i] + polyB[i];
            }
            else if (i < polyA.Length)
            {
                polyC[i] = polyA[i];
            }
            else
            {
                polyC[i] = polyB[i];
            }
        }
        return polyC;
    }
    static int[] SubtractionOfPolynomials(int[] polyA, int[] polyB)
    {
        int[] polyC = new int[Math.Max(polyA.Length, polyB.Length)];
        for (int i = polyC.Length - 1; i >= 0; i--)
        {
            if (i < polyA.Length && i < polyB.Length)
            {
                polyC[i] = polyA[i] - polyB[i];
            }
            else if (i < polyA.Length)
            {
                polyC[i] = polyA[i];
            }
            else
            {
                polyC[i] = polyB[i];
            }
        }
        return polyC;
    }
    static int[] MultiplyingPolynomials(int[] polyA, int[] polyB)
    {
        int[] polyC = new int[polyA.Length + polyB.Length - 1];
        for (int i = 0; i < polyA.Length; i++)
        {
            for (int j = 0; j < polyB.Length; j++)
            {
                polyC[i + j] += polyA[i] * polyB[j];
            }
        }
        return polyC;
    }
    static void PrintingSign(int number)
    {
        if (number < 0)
        {
            Console.Write(" - ");
        }
        else
        {
            Console.Write(" + ");
        }
    }
    static void PrintingResultPolynomial(int[] polyC)
    {
        for (int i = 0; i < polyC.Length; i++)
        {
            if (polyC[i] != 0)
            {
                if (i > 0 || polyC[i] < 0)
                {
                    PrintingSign(polyC[i]);
                }
                Console.Write(Math.Abs(polyC[i]));
                if (i < polyC.Length - 1)
                {
                    Console.Write("x");
                    if (i < polyC.Length - 2)
                    {
                        Console.Write(polyC.Length - i - 1);
                    }
                }
            }
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("Starting polynomials :");
        int n = GetPolynomialSize("first");
        int[] polyA = new int[n];
        polyA = PolynomialElements(n, "first");
        int m = GetPolynomialSize("second");
        int[] polyB = new int[m];
        polyB = PolynomialElements(m, "second");
        Console.Write("Polynomial A = ");
        PrintingResultPolynomial(polyA);
        Console.Write("Polynomial B = ");
        PrintingResultPolynomial(polyB);
        Console.WriteLine();
        Console.WriteLine("Operations :");
        Console.Write(" A + B = ");
        int[] polyC = SumOfPolynomials(polyA, polyB);
        PrintingResultPolynomial(polyC);
        Console.Write(" A - B = ");
        polyC = SubtractionOfPolynomials(polyA, polyB);
        PrintingResultPolynomial(polyC);
        Console.Write(" B - A = ");
        polyC = SubtractionOfPolynomials(polyB, polyA);
        PrintingResultPolynomial(polyC);
        Console.Write(" A * B = ");
        polyC = MultiplyingPolynomials(polyA, polyB);
        PrintingResultPolynomial(polyC);
        Console.WriteLine("");
    }
}
