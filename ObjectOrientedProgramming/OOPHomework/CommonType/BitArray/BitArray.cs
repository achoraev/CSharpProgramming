namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray : IEnumerable<int>
    {
        private readonly ulong number;

        //construktor
        public BitArray(ulong number = 0)
        {
            this.number = number;
        }
       
        //get bit
        public int[] Bits
        {
            get { return this.GetBits(); }
        }

        //indexator
        public int this[int index]
        {
            get
            {
                if (!this.IndexCheck(index))
                {
                    throw new ArgumentOutOfRangeException();
                }
                int[] bits = this.GetBits();
                return bits[index];
            }
        }

        // Methods
        public static bool operator ==(BitArray firstArray, BitArray secondArray)
        {
            return BitArray.Equals(firstArray, secondArray);
        }

        public static bool operator !=(BitArray firstArray, BitArray secondArray)
        {
            return !BitArray.Equals(firstArray, secondArray);
        }

        // Enumerator interface implementation
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        public IEnumerator<int> GetEnumerator()
        {
            int[] bits = this.GetBits();

            for (int i = 0; i < bits.Length; i++)
            {
                yield return bits[i];
            }
        }

        public bool Equals(BitArray value)
        {
            if (ReferenceEquals(null, value))
            {
                return false;
            }

            if (ReferenceEquals(this, value))
            {
                return true;
            }

            return this.number == value.number;
        }

        public override bool Equals(object obj)
        {
            BitArray temp = obj as BitArray;
            if (temp == null)
            {
                return false;
            }
            else
            {
                return this.Equals(temp);
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = (result * 23) + this.number.GetHashCode();
                return result;
            }
        }

        // index checker
        private bool IndexCheck(int index)
        {
            if (index < 0 || index > 63)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // bit getter
        private int[] GetBits()
        {
            ulong number = this.number;

            int[] bits = new int[64];
            int counter = 63;

            while (number > 0)
            {
                bits[counter] = (int)number % 2;
                number = number / 2;
                counter--;
            }

            do
            {
                bits[counter] = 0;
                counter--;
            }
            while (counter >= 0);

            return bits;
        }
    }
}
