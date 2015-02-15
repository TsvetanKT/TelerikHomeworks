using System;

class LexicographicArrays
{
    static void Main()
    {
        //03. Write a program that compares two char arrays lexicographically (letter by letter).

        Console.Write("Input number of elements for Array 1 : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Input number of elements for Array 2 : ");
        int m = int.Parse(Console.ReadLine());

        char[] firstArray = new char[n];
        char[] secondArray = new char[m];

        if (n == m)
        {
            Console.WriteLine();
            Console.WriteLine("Input the members of Array 1 : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0} = ",i);
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Input the members of Array 2 : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0} = ", i);
                secondArray[i] = char.Parse(Console.ReadLine());

                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine();
                    Console.WriteLine("Lexicographically Array 2 is First");
                    break;
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine();
                    Console.WriteLine("Lexicographically Array 1 is First");
                    break;
                }
                else if ((i == (n-1)))
                {
                    Console.WriteLine();
                    Console.WriteLine("Lexicographically the arrays are Equal");
                }
            }
        }

        else if (n < m)
        {
            Console.WriteLine();
            Console.WriteLine("Lexicographically Array 1 is First");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Lexicographically Array 2 is First");
        }
    }
}