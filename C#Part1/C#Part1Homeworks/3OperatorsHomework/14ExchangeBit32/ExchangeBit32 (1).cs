using System;

class ExchangeBit32
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter how many bit position: ");
        int howManyBit = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Lower bit: ");
        uint lowerBitP = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter Higher bit: ");
        uint higherBitQ = uint.Parse(Console.ReadLine());
        for (int i = (int)lowerBitP, j = (int)higherBitQ; i <= howManyBit; i++, j++)
        {
            int mask = 1 << i;
            int numMask = ((int)number & mask);
            if (numMask != 0)
            {
                int newNumber = 1 << j;
                Console.WriteLine("The bit of position {0} is 1 and a new number is: {1}.", i, Convert.ToString(newNumber, 2));
            }
            else
            {
                Console.WriteLine("The bit of position {0} is 0.", i);
            }
        }

    }
}