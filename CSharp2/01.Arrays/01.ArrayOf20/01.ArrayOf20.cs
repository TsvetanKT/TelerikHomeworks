﻿using System;

class ArrayOf20
{
    static void Main()
    {
        //01.Write a program that allocates array of 20 integers and initializes each 
        //  element by its index multiplied by 5. Print the obtained array on the console.

        int[] array = new int[20];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
            Console.Write(array[i]+" ");           
        }
        Console.WriteLine();
    }
}

