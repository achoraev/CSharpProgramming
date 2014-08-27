using System;
class ValueBit
{
    static void Main()
    {
        Console.WriteLine("Enter Number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Bit Position:");
        int position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int numMask = (number & mask);
        if (numMask != 0)
        {
            Console.WriteLine("The {0} bit of number {1} is: 1", position, number);
        }
        else
        {
            Console.WriteLine("The {0} bit of number {1} is: 0", position, number);
        }
    }
}