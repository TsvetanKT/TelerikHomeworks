using System;
using System.Linq;

class MatrixSizeN
{
    static void Main()
    {
        //01.Write a program that fills and prints a matrix of size (n, n) 

        Console.Write("Input N : ");
        int n = int.Parse(Console.ReadLine());   // Inputing n
        int currentNum = 0;
        int[,] matrix = new int[n, n];
        Console.WriteLine();


        // part a)

        Console.WriteLine("a)");
        Console.WriteLine();
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                currentNum++;
                matrix[row,col] = currentNum;
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)  //printing a)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //part b)

        Console.WriteLine("b)");
        Console.WriteLine();
        currentNum = 0;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)    //if column is even number
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    currentNum++;
                    matrix[row, col] = currentNum;
                }                
            }
            else                //if column is odd number
            {
                for (int row = ((matrix.GetLength(0))-1); row >= 0; row--)
                {
                    currentNum++;
                    matrix[row, col] = currentNum;
                }                       
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)  //printing b)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col]);   
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //part c)

        currentNum = 0;
        Console.WriteLine("c)");
        Console.WriteLine();
        int x = n - 1;
        int y = 0;
        int[,] matrix2 = new int[n, n];
        for (int currentValue = 1; currentValue <= n * n; currentValue++)
        {
            matrix2[x++, y++] = currentValue;

            if (x == n || y == n)
            {
                x--;
                if (y == n)
                {
                    x--;
                    y--;
                }
                while (x - 1 >= 0 && y - 1 >= 0)
                {
                    x--;
                    y--;
                }
            }
        }

        for (int row = 0; row < matrix2.GetLength(0); row++)  //printing c)
        {
            for (int col = 0; col < matrix2.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix2[row, col]);            
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //part d)

        currentNum = 0;
        Console.WriteLine("d)");
        Console.WriteLine();
        int[,] matrixd = new int[n, n];
        int direction = 1;
        bool end = false;
        int rows = 0;
        int columns = 0;


        while (end==false)
        {
            if (direction==1) //Direction 1 is left side - up to down
            {
                
                for (int i = columns; i < (n-columns); i++)
                {
                    
                    currentNum++;
                    matrixd[i, columns] = currentNum;
                    if (matrixd[i, columns] == n*n)  // If the curent element is final, the loop ends.
                    {
                        end = true;  
                        break;
                    }
                }
                direction++;
                columns++;
            }

            if (direction == 2) //Direction 2 is down side - left to right
            {
                
                for (int i = columns; i < (n - (columns-1)); i++)
                {
                    
                    currentNum++;
                    matrixd[n-columns, i] = currentNum;
                    if (matrixd[n - columns, i] == n*n)
                    {
                        end = true;
                        break;
                    }
                }
                direction++;
                rows++;
            }

            if (direction == 3) //Direction 3 is right side - down to up
            {
                
                for (int i = n-(columns+1); i >= columns-1; i--)
                {
                    
                    currentNum++;
                    matrixd[i, n-columns] = currentNum;
                    if (matrixd[i, n - columns] == n*n)
                    {
                        end = true;
                        break;
                    }
                }
                direction++;
                
            }

            if (direction == 4) //Direction 4 is upper side - right to left
            {
                
                for (int i = n - (columns + 1); i >= columns; i--)
                {
                    
                    currentNum++;
                    matrixd[columns-1, i] = currentNum;
                    if (matrixd[columns - 1, i] == n*n)
                    {
                        end = true;
                        break;
                    }
                }
                direction=1;            
            }
        }

        for (int row = 0; row < matrixd.GetLength(0); row++)  //printing d)
        {
            for (int col = 0; col < matrixd.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrixd[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
