using System;

//02.Write a method GetMax() with two parameters that returns the bigger of two 
//   integers. Write a program that reads 3 integers from the console and prints 
//   the biggest of them using the method GetMax().


class BiggestFrom3Int
{
    static int GetMax(int a, int b)
    {
        //return a > b ? a : b;
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }

    }

    static void Main()
    {
        Console.WriteLine("Enter three numbers :");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.Write("The biggest number is : ");
        Console.WriteLine(GetMax(GetMax(a, b), c));
    }
}
