using System;

class BoolExpression
{
    static void Main()
    {
        Console.WriteLine("Enter Number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Bit Position:");
        int position = int.Parse(Console.ReadLine());
        int mask = (1 << position);
        int numMask = (number & mask);
        if (numMask != 0)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}