using System;
using System.Numerics;

class Catalan
{
    static void Main()
		{
			Console.WriteLine("Enter N: ");
			BigInteger num = int.Parse(Console.ReadLine());
            BigInteger NumFactorial = 1;
            BigInteger FactorialPlus1 = 1;
            BigInteger FactorialPoDve = 1;
				for (int i = 1; i <= num; i++)
				{
                    NumFactorial = NumFactorial * (BigInteger)i;
                }
                for (int i = 1; i <= num+1; i++)
                {
                    FactorialPlus1 = FactorialPlus1 * (BigInteger)i;
                }
                for (int i = 1; i <= num*2; i++)
                {
                    FactorialPoDve = FactorialPoDve * (BigInteger)i;
                }               
            BigInteger catalan = (FactorialPoDve / (FactorialPlus1 * NumFactorial));           
			Console.WriteLine(catalan);
		}
}