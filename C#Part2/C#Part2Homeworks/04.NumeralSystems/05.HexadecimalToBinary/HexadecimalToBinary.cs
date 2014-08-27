using System;
using System.Text;
//Write a program to convert hexadecimal numbers to binary numbers (directly).

class HexadecimalToBinary
{
	static string ConvertHexaToBinary (string number)
	{		
		StringBuilder binaryNum = new StringBuilder();
		for (int i = 0; i < number.Length; i++)
		{	
			switch (number[i])
			{
				case '0': binaryNum.Append("0000"); break;
				case '1': binaryNum.Append("0001"); break;
				case '2': binaryNum.Append("0010"); break;
				case '3': binaryNum.Append("0011"); break;
				case '4': binaryNum.Append("0100"); break;
				case '5': binaryNum.Append("0101"); break;
				case '6': binaryNum.Append("0110"); break;
				case '7': binaryNum.Append("0111"); break;
				case '8': binaryNum.Append("1000"); break;
				case '9': binaryNum.Append("1001"); break;
				case 'A': binaryNum.Append("1010"); break;
				case 'B': binaryNum.Append("1011"); break;
				case 'C': binaryNum.Append("1100"); break;
				case 'D': binaryNum.Append("1101"); break;
				case 'E': binaryNum.Append("1110"); break;
				case 'F': binaryNum.Append("1111"); break;
			}			
		}
        string result = binaryNum.ToString();
		return result;
	}
	
	static void Main()
	{
		Console.WriteLine("Enter Hexadecimal number: "); 
		string hexaNum = Console.ReadLine();
		hexaNum = hexaNum.ToUpper(); // small caps to Up caps 
		string binaryNum = ConvertHexaToBinary(hexaNum);
		Console.WriteLine("Number in binary numeral system is: {0}", binaryNum);
	}
}