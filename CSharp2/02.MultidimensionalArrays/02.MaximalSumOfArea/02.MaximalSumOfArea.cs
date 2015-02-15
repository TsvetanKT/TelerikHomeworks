using System;

class MaximalSumOfArea
{
    static void Main()
    {
        //02.Write a program that reads a rectangular matrix of size N x M and finds in it 
        //   the square 3 x 3 that has maximal sum of its elements.

        int[,] matrix = {             
                {6, 7, 3, 4, 4, 2},
                {3, 3, 9, 8, 5, 6},
                {3, 7, 7, 3, 1, 9},
                {7, 1, 3, 9, 9, 9},
                {7, 4, 9, 9, 8, 9},
                {8, 9, 4, 9, 9, 9},
            };
        Console.WriteLine("Starting matrix :");
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)  //printing the matrix
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        int chosedArea = 3;       //selecting the area 3x3   
        int sum = int.MinValue;
        int maxSum = int.MinValue;
        int startRow = 0;
        int startCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - chosedArea + 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - chosedArea + 1; col++)
            {
                sum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col]
                    + matrix[row, col + 1] + matrix[row, col + 2]
                    + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                    + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    startCol = col;
                    startRow = row;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("The maximal sum in {0}x{0} square is : {1}",chosedArea ,maxSum);
        Console.WriteLine();

        for (int row = startRow; row < startRow + chosedArea; row++)
        {
            for (int col = startCol; col < startCol + chosedArea; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

