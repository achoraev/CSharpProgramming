using System;
using System.Numerics;

class Fibonachi
{
    static void Main()
    {
        BigInteger first = 0;
        BigInteger second = 1;
        BigInteger third = first + second;
        Console.WriteLine("Enter N: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("{0}, ", first);
        Console.Write("{0}, ", second);
        Console.Write("{0}, ",third);
        for (int i = 3; i <= num; i++)
        {
            first = second;
            second = third;
            third = first + second;
            Console.Write("{0}, ", third);
        }
        Console.WriteLine();
    }
}