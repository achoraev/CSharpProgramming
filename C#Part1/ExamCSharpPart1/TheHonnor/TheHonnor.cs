using System;
using System.Numerics;

class TheHonnor
{
    static void Main()
    {
        string number = Console.ReadLine();
        BigInteger result = 0;
        BigInteger count = 0;
        
        for (int i = 1; i < number.Length; i += 2)
        {
            
            if (number[i] < 48 || number[i] > 57)
            {
                continue;
            }
            else
            {
                result += (number[i] - 48);
                count++;                    
            }            
        }
        Console.WriteLine("{0} {1}", count, result);
    }
}