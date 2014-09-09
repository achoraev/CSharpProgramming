namespace ImplementPriorityQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class PriorityQueue<T>
    {
        private readonly BinaryHeap<T> heap;

        public PriorityQueue()
            : this(Comparer<T>.Default)
        {
        }

        public PriorityQueue(IComparer<T> comp)
        {
            this.heap = new BinaryHeap<T>(comp);
        }

        public int Count
        {
            get { return this.heap.Count; }
        }

        public void Clear()
        {
            this.heap.Clear();
        }

        public void Enqueue(T newItem)
        {
            this.heap.Insert(newItem);
        }

        public T Peek()
        {
            return this.heap.Peek();
        }

        public T Dequeue()
        {
            return this.heap.RemoveRoot();
        }
    }
}