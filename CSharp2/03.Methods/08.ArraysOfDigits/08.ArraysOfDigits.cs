using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//08.Write a method that adds two positive integer numbers represented as 
//   arrays of digits (each array element arr[i] contains a digit; the last 
//   digit is kept in arr[0]). Each of the numbers that will be added could
//   have up to 10 000 digits.


class ArraysOfDigits
{
    static void Main()
    {
        byte[] array1 = { 1, 0 };//1
        byte[] array2 = { 9, 9, 8 };//899
        PrintingTheArray(AddingDigits(array1, array2));
        Console.WriteLine();
    }

    static void PrintingTheArray(List<int> list)
    {
        list.Reverse();
        foreach (var item in list)
        {
            Console.Write(item);
        }
    }

    static List<int> AddingDigits(byte[] a, byte[] b)
    {
        var temp = new List<int>();
        int more = 0;
        int len = Math.Max(a.Length, b.Length);
        for (int i = 0; i < len; i++)
        {
            int digit = (i < a.Length ? a[i] : (byte)0) + (i < b.Length ? b[i] : (byte)0) + more;
            more = digit / 10;
            temp.Add(digit % 10);
        }
        if (more == 1) temp.Add(1);
        return temp;
    }
}