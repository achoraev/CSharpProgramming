using System;
using System.Numerics;

class Program246
{
    static void Main()
    {
        BigInteger numA = BigInteger.Parse(Console.ReadLine());
        BigInteger numB = BigInteger.Parse(Console.ReadLine());
        BigInteger numC = BigInteger.Parse(Console.ReadLine());

        BigInteger sumR = 0;
        BigInteger sumRbefore = 0;

        if (numB == 2)
        {
            sumR = numA % numC;
            sumRbefore = sumR;
        }
        else if (numB == 4)
        {
            sumR = numA + numC;
            sumRbefore = sumR;
        }
        else if (numB == 8)
        {
            sumR = numA * numC;
            sumRbefore = sumR;
        }
        if (sumR % 4 == 0)
        {            
            sumR = sumR / 4;
        }
        else
        {
            sumR = sumR % 4;
        }
        
        Console.WriteLine(sumR);
        Console.WriteLine(sumRbefore);
    }
}