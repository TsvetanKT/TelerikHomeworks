using System;

    class NKFactorialsVerTwo
    {
        static void Main()
        {
            //05.Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

            Console.Write(" Insert N (K > N > 1) : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(" Insert K (K > N > 1) : ");
            int k = int.Parse(Console.ReadLine());

            int product = 1;
            int tempProduct = 1;

            int kMinusN = k - n;
            if (k > n)
            {
                for (int i = k; i > kMinusN; i--)
                {
                    tempProduct *= i;
                }
                product *= tempProduct;
                for (int i = 1; i <= n; i++)
                {
                    product *= i;
                }
                Console.WriteLine(" (N!*K!) / (K-N)! = {0}\n", product);
            }
            else
            {
                Console.WriteLine(" Invalid valuabels!");
            }
        }
    }

