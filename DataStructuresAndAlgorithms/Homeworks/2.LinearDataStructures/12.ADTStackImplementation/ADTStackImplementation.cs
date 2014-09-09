﻿// 12.Implement the ADT stack as auto-resizable array. 
// Resize the capacity on demand (when no space is available to add / insert a new element).
namespace ADTStackImplementation
{
    using System;

    public class JStack<T>
    {
        private const int InitialSize = 4;

        private T[] array;
        private int pointer;

        public JStack() : this(InitialSize) { }

        public JStack(int initialSize)
        {
            this.array = new T[initialSize];
            this.pointer = 0;
        }

        public void Push(T element)
        {
            if (this.pointer == this.array.Length)
            {
                AutoGrow();
            }
            array[pointer] = element;
            pointer++;
        }

        public T Peek()
        {
            if (this.pointer == 0)
            {
                throw new ArgumentException("The stack is empty");
            }

            T objectToReturn = this.array[this.pointer - 1];

            return objectToReturn;
        }

        public int Count { get { return this.pointer; } }

        public T Pop()
        {
            pointer--;
            return this.Peek();
        }

        private void AutoGrow()
        {
            T[] newArray = new T[2 * this.array.Length];
            Array.Copy(this.array, newArray, this.array.Length);
            this.array = newArray;
        }
    }
}