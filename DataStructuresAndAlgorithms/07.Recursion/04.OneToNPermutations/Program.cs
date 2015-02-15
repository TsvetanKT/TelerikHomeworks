﻿namespace _04.OneToNPermutations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        //04. Write a recursive program for generating and printing all permutations of the 
        //    numbers 1, 2, ..., n for given integer number n. Example:
        //                n=3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3},					
        //                       {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

        private static void Main()
        {
            int n = 4;
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }

            Permutations(numbers);
        }

        private static void Permutations(int[] numbersSet)
        {
            Array.Sort(numbersSet);
            Permute(numbersSet, 0, numbersSet.Length);
        }

        private static void Permute(int[] numbersSet, int start, int end)
        {
            PrintNumbers(numbersSet);
            int swapValue = 0;
            if (start < end)
            {
                for (int i = end - 2; i >= start; i--)
                {
                    for (int j = i + 1; j < end; j++)
                    {
                        if (numbersSet[i] != numbersSet[j])
                        {
                            swapValue = numbersSet[i];
                            numbersSet[i] = numbersSet[j];
                            numbersSet[j] = swapValue;
                            Permute(numbersSet, i + 1, end);
                        }
                    }

                    swapValue = numbersSet[i];
                    for (int k = i; k < end - 1; )
                    {
                        numbersSet[k] = numbersSet[++k];
                    }

                    numbersSet[end - 1] = swapValue;
                }
            }
        }

        private static void PrintNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }

            Console.WriteLine();
        }
    }
}
