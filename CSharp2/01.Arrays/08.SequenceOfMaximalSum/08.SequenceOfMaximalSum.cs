using System;

class SequenceOfMaximalSum
{
    static void Main()
    {
        //08. Write a program that finds the sequence of maximal sum in given array. Example:
	    //  {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
	    //  Can you do it with only one loop (with single scan through the elements of the array)?

        
        Console.Write("Specify array length N : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Specify number of elements in the sequence K : ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int sum = -2147483648;      //minimal value for int
        int tsum = 0;
        int firstMember = 0;

        Console.WriteLine("Input elements :");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());  //inputing the array
        }
        for (int i = 0; i < (n + 1 - k); i++)
        {
            for (int j = 0; j < k; j++)
            {
                tsum = tsum + array[i + j];  // calculating the sum of k elements
            }
            if (tsum > sum)            // cheking if that sum is the biggest
            {
                sum = tsum;
                firstMember = i;       // if it is, the value is saved and the number of its first element in the array
            }
            tsum = 0;
        }

        Console.WriteLine();
        Console.WriteLine("The maximal sum of sequence of {0} elements in the array is {1}", k, sum);
        Console.Write("The siquence : ");
        for (int i = 0; i < k; i++)
        {
            Console.Write(array[firstMember + i] + " ");
        }
        Console.WriteLine();
    }
}

