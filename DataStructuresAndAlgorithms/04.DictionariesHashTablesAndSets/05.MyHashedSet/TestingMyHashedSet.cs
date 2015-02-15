namespace MyHashedSet
{
    using System;

    public class TestingMyHashedSet
    {
        /*
          05. Implement the data structure "set" in a class HashedSet<T> using your class HashTable<K,T> 
            to hold the elements. Implement all standard set operations like Add(T), Find(T), Remove(T), 
            Count, Clear(), union and intersect.
        */

        public static void Main()
        {
            MyHashedSet<int> set = new MyHashedSet<int>(new int[] { 101, 1001, 254, 500, 7 });

            Console.WriteLine("Elements: " + String.Join(", ",set));
            Console.WriteLine("Count: " + set.Count);

            set.Add(244);
            Console.WriteLine("Find after add: " + set.Find(244));

            Console.WriteLine("Count: " + set.Count);

            set.Remove(244);
            Console.WriteLine("Count after remove an element: " + set.Count);

            Console.WriteLine("\nElements of set A:");
            foreach (var element in set)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n");

            MyHashedSet<int> newSet = new MyHashedSet<int>(new int[] { 1, 2, -100, 999, 7777 });
            Console.WriteLine("Elements of set B:\n" + String.Join(", ", newSet));
            newSet.UnionWhith(set);

            Console.WriteLine("\nElements of Union set(A+B):\n" + String.Join(", ", newSet));
        }
    }
}