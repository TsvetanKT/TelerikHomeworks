using System;

class SequenceOfEquals
{
    static void Main()
    {
        //04. Write a program that finds the maximal sequence of equal elements in an array.
        //    Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

        int num = 0;
        int maxSequence = 1;
        int tnum = 0;
        int tmaxSequence = 1; // t stands for temporarily

        Console.Write("Specify array length (number of elements) : ");
        int n = int.Parse(Console.ReadLine());
        if (n > 0)
        {
            int[] array = new int[n];

            Console.WriteLine("Input elements :");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    continue;
                }
                else if (array[i] == array[i - 1])
                {
                    tnum = array[i];
                    tmaxSequence++;
                    if (tmaxSequence > maxSequence)
                    {
                        maxSequence = tmaxSequence;
                        num = tnum;
                    }
                }
                else
                {
                    tmaxSequence = 1;
                }

            }
            Console.WriteLine();
            Console.WriteLine("Maximal sequence of equal elements in an array :");
            if (maxSequence > 1)
            {
                Console.Write("A sequence of {0} elements --> ",maxSequence);
                for (int i = 0; i < (maxSequence); i++)
                {
                    Console.Write(num + " ");
                }
            }
            else
            {
                Console.WriteLine("There are none sequences of equal elements !");
            }
        }
        else
        {
            Console.WriteLine("Bad input data !!!");
        }
        Console.WriteLine();
    }
}
