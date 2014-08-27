namespace BitArray
{
    using System;
    public class TestBitArray
    {
        public static void Main()
        {
            BitArray myTestBitArray = new BitArray(1546878);
            foreach (var item in myTestBitArray)
            {
                Console.Write("{0}", item);
            }
            Console.WriteLine();
        }
    }
}
