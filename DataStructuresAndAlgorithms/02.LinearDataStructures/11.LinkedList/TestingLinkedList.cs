namespace LinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class LinkedList
    {
        //11. Implement the data structure linked list. Define a class ListItem<T> that has two fields: value (of type T) 
        //    and NextItem (of type ListItem<T>). Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).

        static void Main()
        {
            var linkedList = new CustomLinkedList<int>();

            linkedList.AddFirst(15);
            linkedList.AddLast(101);
            linkedList.AddFirst(20);
            linkedList.AddFirst(10);
            linkedList.AddLast(505);
            linkedList.AddAfter(linkedList.FirstElement.NextItem.NextItem.NextItem, 5006);
            linkedList.AddBefore(linkedList.FirstElement.NextItem.NextItem.NextItem, 1000001);
            linkedList.AddBefore(linkedList.FirstElement, 0);

            linkedList.RemoveFirst();
            linkedList.RemoveLast();

            ListItem<int> next = linkedList.FirstElement;

            Console.WriteLine("Testing CustomLinkedList\n");
            while (next != null)
            {
                Console.WriteLine(next.Value);
                next = next.NextItem;
            }
            Console.WriteLine(linkedList.Count);
        }
    }
}