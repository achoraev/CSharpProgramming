using System;
using System.Numerics;

class FactorialTwo
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int secondNumber = int.Parse(Console.ReadLine());
        BigInteger NFactorial = 1;
        BigInteger KFactorial = 1;
        BigInteger KNFactorial = 1;
        if (secondNumber > firstNumber && firstNumber > 1)
        {            
            for (int i = 1; i <= firstNumber; i++)
            {
                NFactorial *= i;
            }            
            for (int j = 1; j <= secondNumber; j++)
            {
                KFactorial *= j;
            }            
            for (int k = 1; k <= (secondNumber-firstNumber); k++)
            {
                KNFactorial *= k;
            }           
            BigInteger result = ((NFactorial * KFactorial) / KNFactorial);
            Console.WriteLine(NFactorial);
            Console.WriteLine(KFactorial);
            Console.WriteLine(KNFactorial);
            Console.WriteLine("N!*K!/(K-N)! = " + result);
        }
        else
        {
            Console.WriteLine("Wrong Number: K > N > 1 !!!");
        }       
    }
}