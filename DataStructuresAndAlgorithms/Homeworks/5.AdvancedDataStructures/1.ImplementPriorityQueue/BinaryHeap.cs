namespace ImplementPriorityQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class BinaryHeap<T>
    {
        private readonly IComparer<T> comparer;
        private readonly List<T> items = new List<T>();

        public BinaryHeap()
            : this(Comparer<T>.Default)
        {
        }

        public BinaryHeap(IComparer<T> comp)
        {
            this.comparer = comp;
        }

        public int Count
        {
            get { return this.items.Count; }
        }

        public void Clear()
        {
            this.items.Clear();
        }

        public void Insert(T newItem)
        {
            int i = this.Count;
            this.items.Add(newItem);
            
            while (i > 0 && this.comparer.Compare(this.items[(i - 1) / 2], newItem) > 0)
            {
                this.items[i] = this.items[(i - 1) / 2];
                i = (i - 1) / 2;
            }

            this.items[i] = newItem;
        }

        public T Peek()
        {
            if (this.items.Count == 0)
            {
                throw new InvalidOperationException("The heap is empty.");
            }

            return this.items[0];
        }

        public T RemoveRoot()
        {
            if (this.items.Count == 0)
            {
                throw new InvalidOperationException("The heap is empty.");
            }

            T root = this.items[0];

            T tmp = this.items[this.items.Count - 1];
            this.items.RemoveAt(this.items.Count - 1);
            if (this.items.Count > 0)
            {               
                int i = 0;
                while (i < this.items.Count / 2)
                {
                    int j = (2 * i) + 1;
                    if ((j < this.items.Count - 1) && (this.comparer.Compare(this.items[j], this.items[j + 1]) > 0))
                    {
                        ++j;
                    }

                    if (this.comparer.Compare(this.items[j], tmp) >= 0)
                    {
                        break;
                    }

                    this.items[i] = this.items[j];
                    i = j;
                }

                this.items[i] = tmp;
            }

            return root;
        }
    }
}