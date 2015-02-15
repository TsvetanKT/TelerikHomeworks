using System;

    class MinAndMax
    {
        static void Main()
        {
            //03.Write a program that reads from the console a sequence of N integer 
            //  numbers and returns the minimal and maximal of them.

            Console.Write(" Input N number of siquence members (N>1) : ");
            int n = int.Parse(Console.ReadLine());
            int? min = null;                   // ? after intriger data type allows null as a value
            int? max = null;

            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.Write(" Input element {0} : ",i);
                int element = int.Parse(Console.ReadLine());

                if (min == null)
                {
                    min = element;
                    max = element;
                }

                if (element>max)
                {
                    max=element;
                }
                else if (element < min)
                {
                    min = element;
                }                
            }
            Console.WriteLine();
            Console.WriteLine("The minimial number in your sequence is "+min);
            Console.WriteLine("The maximal number in your sequence is "+max);
        }
    }

