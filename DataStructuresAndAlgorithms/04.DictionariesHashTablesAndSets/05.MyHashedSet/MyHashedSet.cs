namespace MyHashedSet
{   
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using HashTable;

    public class MyHashedSet<T> : IEnumerable<T>
    {
        private MyHashTable<T, T> container;

        public MyHashedSet(params T[] values)
        {
            this.container = new MyHashTable<T, T>();
            if (values != null)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    this.container.Add(values[i], values[i]);
                }
            }
        }

        public int Count
        {
            get { return this.container.Count; }
            private set { }
        } 

        public void Add(T value)
        {
            this.container.Add(value, value);
        }

        public void Remove(T value)
        {
            this.container.Remove(value);
        }

        public T Find(T value)
        {
            T lookedValue = this.container.Find(value);
            return lookedValue;
        }

        public void Clear()
        {
            this.container = new MyHashTable<T, T>();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.container)
            {
                yield return item.Value;
            }
        }

        public void UnionWhith(MyHashedSet<T> otherSet)
        {
            foreach (var item in otherSet)
            {
                if (!this.container.Contains(new KeyValuePair<T, T>(item, item)))
                {
                    this.container.Add(item, item);
                }
            }
        }

        public void IntersectWith(MyHashedSet<T> otherSet)
        {
            MyHashTable<T, T> otherTable = new MyHashTable<T, T>();
            foreach (var item in otherSet)
            {
                if (this.container.Contains(new KeyValuePair<T, T>(item, item)))
                {
                    otherTable.Add(item, item);
                }
            }

            this.container = otherTable;
        }
    }
}
