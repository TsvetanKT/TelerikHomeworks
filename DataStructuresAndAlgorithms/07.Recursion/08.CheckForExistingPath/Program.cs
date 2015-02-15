namespace CheckForExistingPath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        //08. Modify the above program to check whether a path exists between 
        //    two cells without finding all possible paths. Test it over an 
        //    empty 100 x 100 matrix.

        static string[,] labyrinth = new string[100, 100];

        static void Main()
        {
            for (int row = 0; row < 100; row++)
            {
                for (int col = 0; col < 100; col++)
                {
                    labyrinth[row, col] = " ";
                }
            }

            labyrinth[30, 30] = "e";
            //labyrinth[31, 30] = "*"; //      *
            //labyrinth[30, 31] = "*"; // =>  *e* 
            //labyrinth[29, 30] = "*"; //      *
            //labyrinth[30, 29] = "*";

            Stack<int> stack = new Stack<int>();
            Console.WriteLine("Path exists: " + CheckPath(5, 5, 0, stack));
        }

        private static bool CheckPath(int row, int col, int count, Stack<int> stack)
        {
            if (row < 0 || col < 0 ||
            row >= labyrinth.GetLength(0) || col >= labyrinth.GetLength(1))
            {
                return false;
            }

            if (labyrinth[row, col] == "e")
            {
                return true;
            }

            if (labyrinth[row, col] != " ")
            {
                return false;
            }

            stack.Push(count);

            labyrinth[row, col] = count.ToString();

            count++;

            if (CheckPath(row, col - 1, count, stack))
            {
                return true;
            }

            if (CheckPath(row - 1, col, count, stack))
            {
                return true;
            }

            if (CheckPath(row, col + 1, count, stack))
            {
                return true;
            }

            if (CheckPath(row + 1, col, count, stack))
            {
                return true;
            }

            labyrinth[row, col] = " ";

            if (stack.Count > 0)
            {
                stack.Pop();
            }

            return false;
        }
    }
}
