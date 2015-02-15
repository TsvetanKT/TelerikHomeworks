using System;

//04.Write a method that counts how many times given number appears in given
//   array. Write a test program to check if the method is working correctly.

public class NumberAppearingInArray
{
    public static int[] RandomlyFilledArray(int [] array) // fills an array with random numbers (0..9)
    {
        Random random = new Random();
        Console.WriteLine("Randomly generated array with {0} elements : \n",array.Length);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 10);
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        return array;
    }

    public static int Counter(int[] array, int number)
    {
        int counter = 0;
        foreach (int num in array)
        {
            if (num == number)
            {
                counter++;
            }
        }
        return counter;

    }

    static void Main()
    {
        int[] array = new int[25];
        RandomlyFilledArray(array);       
        Console.WriteLine();
        Console.Write("Enter the number : ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Your number appears {0} times in the array.",Counter(array, number));
    }
}
