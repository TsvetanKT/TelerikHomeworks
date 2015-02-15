using System;

class Program
{
    //08.Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
    //
    //09.Implement an indexer this[row, col] to access the inner matrix cells.
    //
    //10.Implement the operators + and - (addition and subtraction of matrices of the same size)
    //   and * for matrix multiplication. Throw an exception when the operation cannot be performed. 
    //   Implement the true operator (check for non-zero elements).
    static void Main()
    {
        Matrix<int> m1 = new Matrix<int>(3, 3);
        Matrix<int> m2 = new Matrix<int>(3, 3);

        // Filling with random numbers
        Random randomGenerator = new Random();
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Cols; j++)
            {
                m1[i, j] = randomGenerator.Next(10);
                m2[i, j] = randomGenerator.Next(10);
            }
        }

        Console.WriteLine("Matrix 1:");
        Console.WriteLine(m1);

        Console.WriteLine("Matrix 2:");
        Console.WriteLine(m2);

        Console.WriteLine("Matrix 1 + Matrix 2:");
        Console.WriteLine(m1 + m2);

        Console.WriteLine("Matrix 1 - Matrix 2:");
        Console.WriteLine(m1 - m2);

        Console.WriteLine("Matrix 1 * Matrix 2:");
        Console.WriteLine(m1 * m2);

        Console.WriteLine(m1 ? "Not empty" : "Empty");
    }
}