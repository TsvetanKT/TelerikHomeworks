using System;

class FrequentNumber
{
    static void Main()
    {
        //09.Write a program that finds the most frequent number in an array. Example:
	    //   {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)


        /*Console.Write("Enter array length : ");         // if you like to input your own array
        int arrayLength = int.Parse(Console.ReadLine());     

        int[] array1 = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Input {0} element : ", i);
            array1[i] = int.Parse(Console.ReadLine());
        } */

        int[] array1 = new int[13] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 }; 
 
        for (int i = 0; i < array1.Length-1; i++)
        {
            for (int j = i+1; j < array1.Length; j++)
            {
                 if (array1[i]>=array1[j])
                {
                    int a = array1[i];
                    array1[i] = array1[j];
                    array1[j] = a;                  
                 }
             }
        }
        int counter = 0;
        int bigCounter = 0;
        int whatNum = 0;
        for (int i = 0; i < array1.Length-1; i++)
        {
            if (array1[i] == array1[i + 1])
            {
                counter++;
                if (bigCounter <= counter)
                {
                    bigCounter = counter;
                    whatNum = array1[i];
                }
            }
            else
            {
                counter = 0;
            }
        }
        Console.WriteLine("The most common number in the array is {0}",whatNum);
        Console.WriteLine("It is found in {0} places.", bigCounter + 1);
        Console.WriteLine();
    }
}
