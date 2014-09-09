using System;
using System.Text;
// Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
//percentage and in scientific notation. Format the output aligned right in 15 symbols.

class PrintFormated
{       		
	static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());//or float
		Console.WriteLine("Decimal: {0,15:D}", number);
        Console.WriteLine("Hexadecimal: {0,11:X4}", number);
		Console.WriteLine("Percent: {0,15:P2}", number);
		Console.WriteLine("Scient: {0,16:E}", number);
    }
}