using System;
using System.Text;
//Write a program that shows the binary representation of given 16-bit signed integer number 
//(the C# type short).

class DecimalToBinShort
{
	static string ConvertDecimalToBinary (string number)
	{
        StringBuilder binaryArray = new StringBuilder();        
		string binaryNum;
        int numberParse = int.Parse(number);        
		for (int i = 0; i < 50; i++)
		{
            binaryArray.Append((numberParse % 2));
            numberParse /= 2;
            if (numberParse == 0)
			{				
				break;
			}
		}
        if (binaryArray.Length < 16)
        {
            for (int i = binaryArray.Length; i < 16; i++)
            {
                binaryArray.Append("0");
            }
        }
        StringBuilder reversed = new StringBuilder();
        for (int i = binaryArray.Length-1; i >= 0; i--)
        {
            reversed.Append(binaryArray[i]);
        }
		binaryNum = (reversed).ToString();
		return binaryNum;
	}
	
	static string reverseNegative (string number)
	{
        StringBuilder tempBuilder = new StringBuilder();
        string result = null;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == '0')
            {
                tempBuilder.Append("1");
            }
            else
            {
                tempBuilder.Append("0");
            }
        }
        result = tempBuilder.ToString();
        return result;
	}
	
	static void Main()
	{
		Console.WriteLine("Enter decimal number: "); 
		string decimalNum = Console.ReadLine();
		bool negative = false;
		if (int.Parse(decimalNum) < 0)
		{
            decimalNum = Math.Abs(int.Parse(decimalNum)+1).ToString();            
			negative = true;
		}		
		decimalNum = ConvertDecimalToBinary(decimalNum);
		if (negative)
		{
			decimalNum = reverseNegative(decimalNum);
            PrintBin(decimalNum);
		}
        else if (long.Parse(decimalNum) == 0)
		{
            PrintBin(decimalNum);
		}
		else
		{
            Console.WriteLine("Number in binary numeral system is: ");
            PrintBin(decimalNum);
		}		
	}

    private static void PrintBin(string decimalNum)
    {
        for (int i = 0; i < decimalNum.Length / 2; i++)
        {
            Console.Write(decimalNum[i]);
        }
        Console.Write(" ");
        for (int j = decimalNum.Length / 2; j < decimalNum.Length; j++)
        {
            Console.Write(decimalNum[j]);
        }
        Console.WriteLine();
    }
}