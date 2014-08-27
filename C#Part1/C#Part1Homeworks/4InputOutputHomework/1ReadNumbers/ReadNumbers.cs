using System;

class ReadNumbers
{
		static void Main()
		{
            Console.WriteLine("Enter Number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number:");
			int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number:");
			int thirdNumber = int.Parse(Console.ReadLine());
			Console.WriteLine("The sum of the numbers is:" + (firstNumber + secondNumber + thirdNumber));
		}
}
