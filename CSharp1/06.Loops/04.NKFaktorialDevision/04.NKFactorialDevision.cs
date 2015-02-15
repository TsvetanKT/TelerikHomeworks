using System;

    class NKFactorialDevision
    {
        static void Main()
        {
            //04.Write a program that calculates N!/K! for given N and K (1<K<N).

            Console.Write(" Insert N (N > K > 1) : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(" Insert K (N > K > 1) : ");
            int k = int.Parse(Console.ReadLine());

            int product = 1;

            if ((k < n)&&(k>1))
            {
                for (int i = n; i > k; i--)
                {
                    product *= i;
                }
                Console.WriteLine();
                Console.WriteLine(" N!/K! = {0}", product);
            }
            else
            {
                Console.WriteLine(" Invalid valuabels!");
            }
        }
    }

