﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/*05.Write a program that reads a text file containing a square matrix of numbers and 
     finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
     The first line in the input file contains the size of matrix N. Each of the next 
     N lines contain N numbers separated by space. The output should be a single number 
     in a separate text file. Example:
     4
     2 3 3 4
     0 2 3 4   ->  17
     3 7 1 2
     4 3 3 2
*/

class TextSquareMatrix 
{
    static void Main()
    {
        int[,] matrix;
        int sizeOfMatrix;
        string[] matrixRows;
        string currentRow;

        StreamReader readLine;

        using (readLine = new StreamReader(@"..\..\..\TextFiles\OneArrayFor05.txt"))
        {
            sizeOfMatrix = int.Parse(readLine.ReadLine());
            matrix = new int[sizeOfMatrix, sizeOfMatrix];
            matrixRows = new string[sizeOfMatrix];
            for (int i = 1; i <= sizeOfMatrix; i++)
            {
                currentRow = readLine.ReadLine();
                currentRow = currentRow.Trim('\t', '\n',' ');
                matrixRows[i - 1] = currentRow;
            }
        }

        for (int i = 0; i < matrixRows.Length; i++)
        {
            string rowFilling = matrixRows[i];
            for (int j = 0, n = 0; j < rowFilling.Length; j++)
            {
                if (rowFilling[j] != ' ' )
                {
                    matrix[i, n] = int.Parse(rowFilling[j].ToString());
                    n++;
                }
            }
        }

        int maxSum = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int tempSum = matrix[row, col] + matrix[row, (col + 1)] +
                    matrix[(row + 1), col] + matrix[(row + 1), (col + 1)];
                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                }
            }
        }
        Console.WriteLine("05.The max sum in square 2x2 in the matrix is: "+maxSum);
    }
}