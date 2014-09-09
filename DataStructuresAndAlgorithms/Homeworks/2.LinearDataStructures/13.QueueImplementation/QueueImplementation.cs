﻿// 13.Implement the ADT queue as dynamic linked list. Use generics (LinkedQueue<T>) to allow storing different data types in the queue.
namespace QueueImplementation
{
    using System;
    using System.Collections.Generic;

    public class JQueue<T>
    {
        private readonly LinkedList<T> list;

        public JQueue()
        {
            this.list = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            this.list.AddLast(item);
        }

        public T Peek()
        {
            if (this.list.Count == 0)
            {
                throw new ArgumentException("The queue is empty!");
            }
            return this.list.First.Value;
        }

        public T Dequeue()
        {
            T itemToGet = this.Peek();
            this.list.RemoveFirst();
            return itemToGet;
        }

        public int Count { get { return this.list.Count; } }
    }
}