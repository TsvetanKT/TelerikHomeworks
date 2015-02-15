using System;

    class SumSX
    {
        static void Main()
        {
            //06.Write a program that, for a given two integer numbers N and X,
            // calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

            Console.Write(" Insert N : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(" Insert X : ");
            int x = int.Parse(Console.ReadLine());

            double sum = 1;
            double nFact = 1;
            double powerX;

            for (int i = 1; i <= n; i++)
            {
                powerX = (int)Math.Pow(x, i);
                nFact *= i;
                sum += nFact / powerX;
            }

            Console.WriteLine();
            Console.WriteLine(" S = "+sum);

        }
    }
