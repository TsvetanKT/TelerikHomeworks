namespace PriorityQueueT
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestingPriorityQueueT
    {
        // 01.Implement a class PriorityQueue<T> based on the data structure "binary heap".

        public static void Main()
        {
            PriorityQueue<int> heap = new PriorityQueue<int>(2);
            heap.Enqueue(0);
            heap.Enqueue(1);
            heap.Enqueue(2);
            heap.Enqueue(5);
            heap.Dequeue();
            heap.Enqueue(333);
            heap.Enqueue(66);

            Console.WriteLine("Dequeue: " + heap.Dequeue());

            heap.Print();
            heap.Enqueue(2);
            heap.Print();
        }
    }
}
