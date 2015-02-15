namespace CustomAutoResizableStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TestingCustomAutoResizableStack
    {
        //12. Implement the ADT stack as auto-resizable array. Resize the capacity on demand 
        //    (when no space is available to add / insert a new element).

        static void Main()
        {
            Console.WriteLine("Testing CustomAutoResizableStack:\n");

            CustomAutoResizableStack<int> CustomAutoResizableStack = new CustomAutoResizableStack<int>();
            CustomAutoResizableStack<int> anotherAutoResizableStack = new CustomAutoResizableStack<int>(30);

            Console.WriteLine("Capacityes of empty stacks:");
            Console.WriteLine(CustomAutoResizableStack.Capacity);
            Console.WriteLine(anotherAutoResizableStack.Capacity);
            Console.WriteLine();

            Console.WriteLine("Count of empty stacks:");
            Console.WriteLine(CustomAutoResizableStack.Count);
            Console.WriteLine(anotherAutoResizableStack.Count);
            Console.WriteLine();

            CustomAutoResizableStack.Push(15);
            CustomAutoResizableStack.Push(30);
            CustomAutoResizableStack.Push(5);

            Console.WriteLine("Filled with 15, 30, 5:");
            Console.WriteLine(CustomAutoResizableStack);
            Console.WriteLine("Count: " + CustomAutoResizableStack.Count);
            Console.WriteLine("Capacity: " + CustomAutoResizableStack.Capacity);
            Console.WriteLine("Peek(): " + CustomAutoResizableStack.Peek());
            Console.WriteLine();

            Console.WriteLine("Pop(): " + CustomAutoResizableStack.Pop());
            Console.WriteLine(CustomAutoResizableStack);
            Console.WriteLine();

            CustomAutoResizableStack.Push(55);
            CustomAutoResizableStack.Push(70);
            CustomAutoResizableStack.Push(33);

            Console.WriteLine("Pushed  with 55, 70, 33:");
            Console.WriteLine(CustomAutoResizableStack);
            Console.WriteLine("Count: " + CustomAutoResizableStack.Count);
            Console.WriteLine("Capacity: " + CustomAutoResizableStack.Capacity);
            Console.WriteLine();

            CustomAutoResizableStack.TrimExcess();
            CustomAutoResizableStack.Clear();
        }
    }
}
