using System;

class CombinationsOfDistinct 
{
    static void Main()
    {
        //21.Write a program that reads two numbers N and K and generates all the combinations of K distinct
        //   elements from the set [1..N]. Example:
	    //   N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
        Console.Write("Input N : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Input K : ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (n >= k)
        {
            int[] myArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                myArr[i] = i + 1;
            }

            Console.Write("The array : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(myArr[i] + " ");
            }
            Console.WriteLine();

            int combinations = (int)(Math.Pow(2, n) - 1); // calculating all possible combinations

            Console.WriteLine("Different combinations of {0} distinct elements :", k);
            for (int i = 1; i <= combinations; i++)
            {
                int counterOnes = 0;
                for (int j = 0; j < n; j++)
                {
                    byte bit = (byte)(i >> j & 1);
                    if (bit == 1)
                    {
                        counterOnes++;
                    }
                }

                if (counterOnes == k)
                {
                    for (int j = 0; j < n; j++)
                    {
                        byte bit = (byte)(i >> j & 1);
                        if (bit == 1)
                        {
                            Console.Write(myArr[j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
        else
        {
            Console.WriteLine("ERROR! N must be bigger than K.");
        }
        Console.WriteLine();
    }
}