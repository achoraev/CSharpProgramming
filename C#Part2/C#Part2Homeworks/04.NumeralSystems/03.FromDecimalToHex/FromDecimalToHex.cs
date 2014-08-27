using System;
using System.Text;
//Write a program to convert decimal numbers to their hexadecimal representation.

class FromDecimalToHex
{
    static string ConvertDecimalToHex(int number, int numeralSystem)
    {
        StringBuilder binaryArray = new StringBuilder();
        string result="";
        for (int i = 0; i <= binaryArray.Length; i++)
        {
            if ((number % numeralSystem) > 9)
            {
                switch (number % numeralSystem)
                {
                    case 10: binaryArray.Append('A'); break;
                    case 11: binaryArray.Append('B'); break;
                    case 12: binaryArray.Append('C'); break;
                    case 13: binaryArray.Append('D'); break;
                    case 14: binaryArray.Append('E'); break;
                    case 15: binaryArray.Append('F'); break;
                }            
            }
            else
            {
                binaryArray.Append((number % numeralSystem).ToString());
            }            
            number = number / numeralSystem;
            if (number == 0)
            {
                result = binaryArray.ToString();                
                break;
            }
        }        
        return result; // return not reversed number
    }// convert from decimal to any numeral system

    static void Main()
    {
        Console.WriteLine("Enter decimal number: ");
        int decimalNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter numberal system: "); // enter 16 for hexadecimal
        int numeralSystem = int.Parse(Console.ReadLine());
        string convertedArray = ConvertDecimalToHex(decimalNum, numeralSystem);
        Console.Write("Number in {0} numerical system is: ", numeralSystem);
        for (int i = convertedArray.Length-1; i >= 0; i--)
        {
            Console.Write(convertedArray[i]);
        }
        Console.WriteLine();
    }
}