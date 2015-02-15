namespace HashTableCustomHashTable
{   
    using System;
    using HashTable;

    public class CustomHashTable
    {
        /*
         04. Implement the data structure "hash table" in a class HashTable<K,T>. Keep the data in array of lists 
            of key-value pairs (LinkedList<KeyValuePair<K,T>>[]) with initial capacity of 16. When the hash table 
            load runs over 75%, perform resizing to 2 times larger capacity. Implement the following methods and properties: 
            Add(key, value), Find(key) -> value, Remove( key), Count, Clear(), this[], Keys. Try to make the hash table to 
            support iterating over its elements with foreach.
        */

        public static void Main()
        {
            MyHashTable<int, int> CustomHashTable = new MyHashTable<int, int>();

            for (int i = 0; i < 15; i++)
            {
                CustomHashTable.Add(i, 1 + i);
            }

            var searchedNumber = 5;
            Console.WriteLine("Find index of {0}: {1}", searchedNumber, CustomHashTable.Find(searchedNumber));

            CustomHashTable[6] = 1001;

            Console.WriteLine("Edit element through []: " + CustomHashTable[6]);
            Console.WriteLine(CustomHashTable.Keys);

            Console.WriteLine("\nAll elements:");
            foreach (var item in CustomHashTable)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }

            CustomHashTable.Add(30, 1);
            CustomHashTable.Add(100, 1);
            CustomHashTable.Add(1000, 1);
            CustomHashTable.Add(10000, 1);
            CustomHashTable.Add(20, 1);
            CustomHashTable.Add(200, 1);
            CustomHashTable.Add(2000, 1);
            CustomHashTable.Add(20000, 1);
            Console.WriteLine("\nCount: " + CustomHashTable.Count);
            Console.WriteLine("Capacity: " + CustomHashTable.Capacity);
        }
    }
}