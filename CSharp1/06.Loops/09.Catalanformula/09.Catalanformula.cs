using System;

    class Catalanformula
    {
        static void Main()
        {
            //09.In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
            // (2n)! / ((n + 1)! * n!) for n>=0

            Console.Write(" n = ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 0)
            {
                int middleProduct = 1;
                decimal answer = 1;

                int nPlusOne = n + 1;
                for (int i = 2 * n; i > nPlusOne; i--)
                {
                    middleProduct *= i; // calculation  (2n)! / (n + 1)!
                }
                answer *= middleProduct;
                for (int i = 1; i <= n; i++)
                {
                    answer /= i; // devide (2n)! / (n + 1)! with n!
                }

                Console.WriteLine();
                Console.WriteLine(" (2n)! / ((n + 1)! * n!) = {0}\n", answer);
            }
            else
            {
                Console.WriteLine(" n must be >= 0 !");
                Main();
            }
        }
    }

