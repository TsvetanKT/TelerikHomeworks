namespace ReverseWithStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ReverseWithStack
    {
        // 02. Write a program that reads N integers from the console and reverses them using a stack. 
        //    Use the Stack<int> class.

        static void Main()
        {
            var generatedStack = RandomGeneratedStack(3, 9, 0, 10);
            var anotherStack = new Stack<int>();
            int len = generatedStack.Count;
            Console.WriteLine();

            for (int i = 0; i < len; i++)
            {
                int value = generatedStack.Pop();
                Console.WriteLine("New element {0} is {1}", i , value);
                anotherStack.Push(value);
            }

        }

        static Stack<int> RandomGeneratedStack(int stackMin, int stacktMax, int min, int max)
        {
            Random random = new Random();
            int randomLenght = random.Next(stackMin, stacktMax);
            var generatedStack = new Stack<int>();

            for (int i = 0; i < randomLenght; i++)
            {
                int value = random.Next(min, max);
                Console.WriteLine("Element {0} is  {1}", i , value);
                generatedStack.Push(value);
            }

            return generatedStack;
        }
    }
}
