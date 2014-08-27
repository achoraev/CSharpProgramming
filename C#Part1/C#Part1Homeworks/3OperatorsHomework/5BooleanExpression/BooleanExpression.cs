using System;

class BooleanExpression
{
    static void Main()
    {
        Console.WriteLine("Enter Number:");
        int number = int.Parse(Console.ReadLine());
        int position = 3;
        int mask = (1 << position);
        int numMask = (number & mask);
        if (numMask != 0)
        {
            Console.WriteLine("The 3 bit is: 1");
        }
        else
        {
            Console.WriteLine("The 3 bit is: 0");
        }
    }
}
