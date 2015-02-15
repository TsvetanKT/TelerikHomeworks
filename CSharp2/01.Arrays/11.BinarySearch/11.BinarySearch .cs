using System;

class BinarySearch 
{
    static void Main()
    {
        //11.Write a program that finds the index of given element in a sorted array
        //   of integers by using the binary search algorithm (find it in Wikipedia).

        int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        Array.Sort(intArray);
        int firstMember = 0;
        int lastMember = intArray.Length - 1;
        int midMember = (firstMember + lastMember) / 2;

        int target = 10;    // This is the target number
        int index = -1;    

        while (lastMember >= firstMember)
        {
            midMember = (firstMember + lastMember) / 2;

            if (intArray[midMember] < target)
            {
                // change min index to search the upper array part
                firstMember = midMember + 1;
            }
            else if (intArray[midMember] > target)
            {
                // change max index to search the lower array part
                lastMember = midMember - 1;
            }
            else
            {
                index = midMember;
                break;
            }
        }
        if (index >= 0)
        {
            Console.WriteLine("The requestred number {0} is at index {1}", target, index);
        }
        else if (index < 0)
        {
            Console.WriteLine("The index of the requestred number {0} was not found in the given array", target);
        }
    }
}

