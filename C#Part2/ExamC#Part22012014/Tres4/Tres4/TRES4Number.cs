using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text; 

class TRES4Number
{
    static void Main()
    {        
		// input
        BigInteger input = BigInteger.Parse(Console.ReadLine());
		string convertToString = ConvertFromDecimal(input, 9);	
		StringBuilder result = new StringBuilder();
		// solution
		for (int i = 0; i < convertToString.Length; i++)
		{
			switch (convertToString[i])
			{
				case '0': result.Append("LON+"); break;
				case '1': result.Append("VK-"); break;
				case '2': result.Append("*ACAD"); break;
				case '3': result.Append("^MIM"); break;
				case '4': result.Append("ERIK|"); break;
				case '5': result.Append("SEY&"); break;
				case '6': result.Append("EMY>>"); break;
				case '7': result.Append("/TEL"); break;
				case '8': result.Append("<<DON"); break;
			}
		}
		//result
		Console.WriteLine(result.ToString());		
    }

    static string ConvertFromDecimal(BigInteger number, int numeralSystem)
    {
        StringBuilder binaryArray = new StringBuilder();
        string result = string.Empty;
        for (int i = 0; i <= binaryArray.Length; i++)
        {
            if ((number % numeralSystem) > 9)
            {
                //switch (number % numeralSystem)
                //{
                //    case 10: binaryArray.Append('A'); break;
                //    case 11: binaryArray.Append('B'); break;
                //    case 12: binaryArray.Append('C'); break;
                //    case 13: binaryArray.Append('D'); break;
                //    case 14: binaryArray.Append('E'); break;
                //    case 15: binaryArray.Append('F'); break;
                //}
            }
            else
            {
                binaryArray.Append((number % numeralSystem).ToString());
            }
            number = number / numeralSystem;
            if (number == 0)
            {
                if (binaryArray.Length > 1)
                {
                    result = ReverseDigit(binaryArray);
                }
                else
                {
                    result = binaryArray.ToString(); 
                }
                break;
            } 
        }        
        return result;
    }
    
	static string ReverseDigit(StringBuilder binaryArray)
    {
        StringBuilder result = new StringBuilder();
        for (int i = binaryArray.Length-1; i >= 0; i--)
        {
            result.Append(binaryArray[i]);
        }
        string final = result.ToString();
        return final;
    }
    

}
