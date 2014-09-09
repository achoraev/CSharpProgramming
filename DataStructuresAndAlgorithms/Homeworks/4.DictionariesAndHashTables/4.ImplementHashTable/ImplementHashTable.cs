namespace ImplementHashTable
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class HashTable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private const int InitialCapacity = 4;
        private const float MaxLoad = 0.75f;
        private const int ResizeFactor = 2;

        private LinkedList<KeyValuePair<TKey, TValue>>[] table;

        public HashTable()
        {
            this.Clear();
        }

        public int Count { get; private set; }

        public IEnumerable<TKey> Keys
        {
            get
            {
                return this.table.Where(x => x != null).SelectMany(x => x).Select(x => x.Key);
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                return this.Find(key);
            }

            set
            {
                this.Add(key, value);
            }
        }

        public void Clear()
        {
            this.table = new LinkedList<KeyValuePair<TKey, TValue>>[InitialCapacity];
            this.Count = 0;
        }

        public void Add(TKey key, TValue value)
        {
            if (this.ContainsKey(key))
            {
                throw new ArgumentException("An element with the same key already exists in the hash table!");
            }

            if (this.Count >= MaxLoad * this.table.Length)
            {
                this.ResizeTable();
            }

            var pair = new KeyValuePair<TKey, TValue>(key, value);

            int index = this.GetKeyIndex(key, this.table.Length);

            if (this.table[index] == null)
            {
                this.table[index] = new LinkedList<KeyValuePair<TKey, TValue>>();
            }

            this.table[index].AddLast(pair);
            this.Count++;
        }

        public TValue Find(TKey key)
        {
            int index = this.GetKeyIndex(key, this.table.Length);

            if (this.table[index] == null)
            {
                throw new KeyNotFoundException("Specified key not found!");
            }

            var chain = this.table[index];
            foreach (var pair in chain)
            {
                if (pair.Key.Equals(key))
                {
                    return pair.Value;
                }
            }

            throw new KeyNotFoundException("Specified key not found!");
        }

        public bool Remove(TKey key)
        {
            int index = this.GetKeyIndex(key, this.table.Length);

            if (this.table[index] == null)
            {
                return false;
            }

            var chain = this.table[index];
            var pairsToRemove = this.table[index].Where(p => p.Key.Equals(key)).ToList();

            if (pairsToRemove.Count == 0)
            {
                return false;
            }

            foreach (var pair in pairsToRemove)
            {
                chain.Remove(pair);
                this.Count--;
            }

            return true;
        }

        public bool ContainsKey(TKey key)
        {
            int index = this.GetKeyIndex(key, this.table.Length);

            if (this.table[index] == null)
            {
                return false;
            }

            var chain = this.table[index];
            foreach (var pair in chain)
            {
                if (pair.Key.Equals(key))
                {
                    return true;
                }
            }

            return false;
        }

        public void PrintValue(TKey key)
        {
            Console.WriteLine("{0} -> {1}", key, this[key]);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (var chain in this.table)
            {
                if (chain != null)
                {
                    foreach (var pair in chain)
                    {
                        yield return pair;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private int GetKeyIndex(TKey key, int length)
        {
            int index = key.GetHashCode();
            index = index & 0x7FFFFFFF;
            index = index % length;
            return index;
        }

        private void ResizeTable()
        {
            var newTable = new LinkedList<KeyValuePair<TKey, TValue>>[this.table.Length * ResizeFactor];
            int newCount = 0;
            foreach (var chain in this.table)
            {
                if (chain == null)
                {
                    continue;
                }

                foreach (var pair in chain)
                {
                    var key = pair.Key;
                    int index = this.GetKeyIndex(key, newTable.Length);
                    if (newTable[index] == null)
                    {
                        newTable[index] = new LinkedList<KeyValuePair<TKey, TValue>>();
                    }

                    newTable[index].AddLast(pair);
                    newCount++;
                }
            }

            this.table = newTable;
            this.Count = newCount;
        }
    }
}