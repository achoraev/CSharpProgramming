using System;
//Write a program to convert hexadecimal numbers to their decimal representation.

class FromHexadecimalToDecimal
{
	static long ConvertHexaToDecimal (string number)
	{		
        long [] convertedlArray = new long [number.Length];
        long result = 0;
        int numeralSystem = 16;
		for (int i = number.Length-1; i >= 0; i--)
		{			
			switch (number[i])
			{
                case 'A': convertedlArray[i] = 10; break;
                case 'B': convertedlArray[i] = 11; break;
                case 'C': convertedlArray[i] = 12; break;
                case 'D': convertedlArray[i] = 13; break;
                case 'E': convertedlArray[i] = 14; break;
                case 'F': convertedlArray[i] = 15; break;
                default: convertedlArray[i] = int.Parse(number[i].ToString()); break;
			}            
		}
        Array.Reverse(convertedlArray);
        for (int j = number.Length-1; j >= 0; j--)
        {
            result += convertedlArray[j] * PovdiganeNaStepen(numeralSystem, j); 
        }        
        return result;
	}
    static long PovdiganeNaStepen(int numeralSystem, int stepen)
    {
        long result = 1;
        for (int i = 0; i < stepen; i++)
        {
            result *= numeralSystem;
        }
        return result;
    }
	static void Main()
	{
		Console.WriteLine("Enter Hexadecimal number: "); 
		string HexaNum = Console.ReadLine();
        long decimalNum = ConvertHexaToDecimal(HexaNum);
		Console.WriteLine("Number in decimal numeral system is: {0}", decimalNum); 		
	}
}