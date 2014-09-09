using System;
using System.Text;
//Write a program to convert binary numbers to hexadecimal numbers (directly).

class BinaryToHexadecimal
{
	static string ConvertBinToHex (string number)
	{		
		for (int i = 4; i < 32; i *= 2)// mai triabva da e * 2
        {
            if (number.Length < i)
            {
                string leadingZeros = new String('0', i - number.Length);
                number = leadingZeros + number;
                break;
            }
        }

        StringBuilder hexaNum = new StringBuilder();

        for (int i = 0; i < number.Length; i = i + 4)
        {
            StringBuilder currentDigit = new StringBuilder();
            for (int j = i; j < i + 4; j++)
            {
                currentDigit.Append(number[j]);
            }
            string finalDigit = currentDigit.ToString();
            switch (finalDigit)
            {
                case "0000": hexaNum.Append('0'); break;
                case "0001": hexaNum.Append('1'); break;
                case "0010": hexaNum.Append('2'); break;
                case "0011": hexaNum.Append('3'); break;
                case "0100": hexaNum.Append('4'); break;
                case "0101": hexaNum.Append('5'); break;
                case "0110": hexaNum.Append('6'); break;
                case "0111": hexaNum.Append('7'); break;
                case "1000": hexaNum.Append('8'); break;
                case "1001": hexaNum.Append('9'); break;
                case "1010": hexaNum.Append('A'); break;
                case "1011": hexaNum.Append('B'); break;
                case "1100": hexaNum.Append('C'); break;
                case "1101": hexaNum.Append('D'); break;
                case "1110": hexaNum.Append('E'); break;
                case "1111": hexaNum.Append('F'); break;
                default: break;
            }
        }        
        string result = hexaNum.ToString().TrimStart('0');
		return result;
	}
	
	static void Main()
	{
		Console.WriteLine("Enter Binary number: "); 
		string binNum = Console.ReadLine();
		binNum = ConvertBinToHex(binNum);			
		Console.WriteLine("Number in Hexadecimal numeral system is: {0}", binNum); 			
	}
}