using System;
using System.Numerics;

class Zeroes
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        BigInteger num = int.Parse(Console.ReadLine());
        BigInteger sum = 0;
		BigInteger factorial = 1;
		for (BigInteger i = 1; i <= num; i++)
            {
                factorial *= i;
            }           
		if (num % 5 == 0)
		{
			sum = num/5;
		}
		Console.WriteLine("N = {0} -> {0}! = {1} - > {2}", num, factorial,sum);
    }
}