using System;
using System.Collections.Generic;

class FindMaxSeq
{
    static void Main()
    {
        //03.We are given a matrix of strings of size N x M. Sequences in the matrix
        //  we define as sets of several neighbor elements located on the same line, 
        //  column or diagonal. Write a program that finds the longest sequence of 
        //  equal strings in the matrix.

        string[,] matrix =
            {  
                /*
                {"11","22","333","4444"},
                {"op","noob","hop","trop"},
                {"ah","non","none","pro"},
                {"HERE","HERE","HERE","HERE"},
                {"offs","nonak", "leles","male"},
                */

                
                {"ha","fifi","ho","hi"},
                {"fo","ha","hi","xx"},
                {"xxx","ho","ha","xx"},
               

                /*
                {"s","qq","s"},
                {"pp","pp","s"},
                {"pp","qq","s"},
                */

            };

        string element = "";
        int sequence = 0;
        int temp = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,7}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        temp = 0;

        //checking the rows

        for (int row = 0; row < matrix.GetLength(0); row++) 
        {
            for (int col = 0; col < (matrix.GetLength(1)-1); col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    temp++;
                    if (temp > sequence)
                    {
                        sequence = temp;
                        element = matrix[row, col];
                    }
                }
                else
                {
                    temp = 0;
                }
            }
        }
        temp = 0;

        //checking the columns  
     
        for (int col = 0; col < matrix.GetLength(1); col++) 
        {
            for (int row = 0; row < (matrix.GetLength(0) - 1); row++)
            {
                if (matrix[row, col] == matrix[row+1, col])
                {
                    temp++;
                    if (temp > sequence)
                    {
                        sequence = temp;
                        element = matrix[row, col];
                    }
                }
                else
                {
                    temp = 0;
                }
            }
        }
        temp = 0;

        //checking diagonals "\"

        for (int row = 0; row < (matrix.GetLength(0) - 1); row++)
        {
            for (int col = 0; col < (matrix.GetLength(1) - 1); col++)
            {
                if (((row + 1)<=matrix.GetLength(1))&&( col + 1<=matrix.GetLength(0)))
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        //
                        while ((row + 1 < matrix.GetLength(0)) && (col + 1 < matrix.GetLength(1)))
                        {
                            if (matrix[row, col] == matrix[row + 1, col + 1])
                            {
                                temp++;
                                row++;
                                col++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (temp > sequence)
                        {
                            sequence = temp;
                            element = matrix[row, col];
                        }
                    }
                    else
                    {
                        temp = 0;
                    }
                }
            }
        }
        temp = 0;

        //checking diagonals "/"

        for (int row = 0; row < (matrix.GetLength(0) - 1); row++)
        {
            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                if (((row + 1) <= matrix.GetLength(1)) && ((col-1)>0))
                {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        //
                        while ((row + 1 < matrix.GetLength(0)) && (col - 1 >= 0))
                        {
                            if (matrix[row, col] == matrix[row + 1, col - 1])
                            {
                                temp++;
                                row++;
                                col--;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (temp > sequence)
                        {
                            sequence = temp;
                            element = matrix[row, col];
                        }
                    }
                    else
                    {
                        temp = 0;
                    }
                }
            }
        }

        if (sequence > 1)    // Printing the result
        {
            Console.WriteLine("Element {0} is found {1} times.", element, sequence + 1);
            Console.WriteLine();
            for (int i = 0; i < sequence + 1; i++)
            {
                if (i == sequence)
                {
                    Console.Write(element);
                }
                else
                {
                    Console.Write(element + ", ");
                }
            }
        }
        else
        {
            Console.WriteLine("There are NO sequences in the matrix !");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

