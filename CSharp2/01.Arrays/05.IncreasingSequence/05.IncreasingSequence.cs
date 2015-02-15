using System;

class IncreasingSequence
{
    static void Main()
    {
        //05.Write a program that finds the maximal increasing sequence in an array. 
        //   Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

        int num = 0;
        int maxSequence = 1;
        int tnum = 0;
        int tmaxSequence = 1; // t stands for temporarily

        Console.Write("Specify array length (number of elements) : ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            int[] array = new int[n];
            bool[] tarray = new bool[n];

            Console.WriteLine("Input elements :");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());  //inputing the array
                if (i == 0)
                {
                    continue;
                }
                else if (array[i] > array[i - 1])

                /* Filling up the temporary array - true (1) for increase, false (0) for everything else.
                   Example: Original array 3, 2, 3, 4, 2, 2, 4, 7, 11...
                           temporary array 0, 0, 1, 1, 0, 0, 1, 1, 1 ...
                   
                 
                 Now, by finding the maximal sequence of equal elements in the temporary array (like task 04.SequenceOfEquals ),
                 we will know the lenght and the position of the maximal sequence of increasing elements in the original.
                 
                */
                {
                    tarray[i] = true;
                }
            }
            for (int i = 0; i < n; i++)
            {

                if (i == 0)
                {
                    continue;
                }
                else if ((tarray[i] == true) && (tarray[i - 1] == true))
                {
                    tnum = i;  
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
            Console.WriteLine("Maximal sequence of increasing elements in the array :");
            if (maxSequence > 1)
            {
                Console.Write("A sequence of {0} elements --> ", maxSequence + 1);
                for (int i = 0; i < n; i++)
                {
                    if ((i <= num) && (i >= (num - maxSequence)))
                    {
                        Console.Write(array[i] + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("There are none sequences of increasing elements !");
            }
        }
        else
        {
            Console.WriteLine("Bad input data !!!");
        }
        Console.WriteLine();
    }
}
