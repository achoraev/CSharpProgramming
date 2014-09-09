using System;
using System.Numerics;

class Program369

{
    static void Main()
    {
        BigInteger numA = BigInteger.Parse(Console.ReadLine());
        BigInteger numB = BigInteger.Parse(Console.ReadLine());
        BigInteger numC = BigInteger.Parse(Console.ReadLine());

        BigInteger sumR = 0;
        BigInteger sumRbefore = 0;

        if (numB == 3)
        {
            sumR = numA + numC;
            sumRbefore = sumR;
        }
        else if (numB == 6)
        {
            sumR = numA * numC;
            sumRbefore = sumR;
        }
        else if (numB == 9)
        {
            sumR = numA % numC;
            sumRbefore = sumR;
        }
        if (sumR % 3 == 0)
        {
            sumRbefore = sumR;
            sumR = sumR / 3;


        }
        else
        {
            sumR = sumR % 3;
        }
        for (int i = 0; i < 20; i++)
        {
            if (sumR > 9)
            {
                sumR = sumR / 3;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(sumR);
        Console.WriteLine(sumRbefore);
    }
}