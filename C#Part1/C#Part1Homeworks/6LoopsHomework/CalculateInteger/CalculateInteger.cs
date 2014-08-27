using System;

class CalculateInteger
{
		static void Main()
		{
			Console.WriteLine("Enter N: ");
			double numberN = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter X: ");
			double numberX = double.Parse(Console.ReadLine());
			double sum = 0;
			double NFactorial = 1;
			double XonN = 0;
			for (double i = 1; i <= numberN; i++)
			{
			NFactorial *= i;
            XonN = Math.Pow(numberX, i);
			sum += NFactorial/XonN;			
			}
			Console.WriteLine("Sum of 1 + 1!/X + 2!/X^2 + ... N!/X^N is: {0}", sum);
		}
}