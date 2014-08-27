using System;

class Factorial
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int NFactorial=1;
        int KFactorial=1;
        if (firstNumber > secondNumber && secondNumber > 1)
        {            
            for (int i = 1; i <= firstNumber; i++)
            {
                NFactorial *= i;
            }           
            for (int j = 1; j <= secondNumber; j++)
            {
                KFactorial *= j;
            }
            Console.WriteLine("{0} {1}",NFactorial, KFactorial);
            int result = (NFactorial / KFactorial);
            Console.WriteLine("N!/K!= " + result);
        }           
        else
        {
            Console.WriteLine("Wrong Number: N > K > 1 !!!");
        }        
    }
}