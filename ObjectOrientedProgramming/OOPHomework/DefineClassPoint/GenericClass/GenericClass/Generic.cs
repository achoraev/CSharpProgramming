namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Generic<T>
    {
        // field
        private const int DefaultCapacity = 16;
        private T [] elements;
        private int nextElement;
        // properties
        public T [] Elements
        {
            get { return this.elements; }
            set { this.elements = value; }
        }

        public int NextElement
        {
            get { return this.nextElement; }
            set { this.nextElement = value; }
        }
        //construktors
        public Generic()
            :this(DefaultCapacity)
        {         
        }
        
        public Generic(int capacity)
        {
            if (capacity < 0)
            {
                throw new IndexOutOfRangeException("Number must be positive!!!");                
            }
            else
            {
                this.elements = new T[capacity];
                this.NextElement = 0;
            }
        }

        public void AddElement(T element)
        {
            if (this.NextElement > (elements.Length-1))
            {
                AddCapacity(this.NextElement);
            }
            this.Elements[this.NextElement] = element;
            this.NextElement++;
        }
        // 6. Auto grow functionality
        private void AddCapacity(int nextElement)
        {
            T [] newList = new T [nextElement];
            this.Elements.CopyTo(newList, 0);
            nextElement *= 2;
            this.Elements = new T [nextElement];
            newList.CopyTo(this.Elements, 0);
        }   

        public void RemoveElement(int index)
        {
            if (index >= 0 && index < this.nextElement )
            {
                T nextElement = default(T);
                for (int i = index; i < this.elements.Length - 1; i++)
                {
                    nextElement = this.Elements[i + 1];
                    this.Elements[i] = nextElement;
                }
                this.nextElement--;
            }
            else
            {
                throw new IndexOutOfRangeException("Number is out of range!!!");
            }
        }
        // indexer
        public T this [int index]
        {
            get 
            {
                if (index >= 0 && index < this.nextElement)
                {
                    return this.Elements[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range!!!");
                }    
            }
            set
            {
                if (index >= 0 && index < this.nextElement)
                {
                    this.elements[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range!!!"); 
                }            
            }
        }

        public void InsertElement(int index, T element)
        {
            if (index >= 0 && index < this.nextElement)
            {
                if (this.nextElement >= Elements.Length)
                {
                    AddCapacity(this.nextElement);
                }
                for (int i = this.nextElement; i > index; i--)
                {
                    this.elements[i] = this.elements[i - 1];
                }
                this.elements[index] = element;
                this.nextElement++;
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
        }

        public int FindElement(T searchElement)
        {
            if (Array.IndexOf(Elements, searchElement) > 0)
            {
                return Array.IndexOf(Elements, searchElement); 
            }
            else
            {
                throw new ArgumentException("Element is NOT exist!!!");                
            }
        }

        public void ClearList()
        {
            Array.Clear(Elements, 0, Elements.Length);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this.nextElement; i++)
			{
                builder.Append(String.Format("{0}", this.elements[i]));
                if (i < this.nextElement-1)
                {
                    builder.Append(", "); 
                }
			}
            return builder.ToString();
        }
    }
}
