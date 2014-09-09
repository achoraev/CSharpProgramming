using System;
using System.Collections.Generic;
using System.Text;
//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

class FromXToYNumeralSystem
{
    static void Main()
    {
        Console.WriteLine("Enter FROM which numeral system u like to convert(2-16): ");
        int fromX = int.Parse(Console.ReadLine());
        if (fromX >= 16 || fromX < 2)
        {
            Console.WriteLine("Wrong number!!!");
        }
        Console.WriteLine("Enter TO which numeral system u like to convert(2-16): ");
        int toX = int.Parse(Console.ReadLine());
        if (fromX >= 16 || fromX < 2)
        {
            Console.WriteLine("Wrong number!!!");
        }
        Console.WriteLine("Enter number: ");
        string numberToConvert = Console.ReadLine();
        numberToConvert = numberToConvert.ToUpper();
        long convertToDecimal = ConvertToDecimal(numberToConvert, fromX);
        string result = ConvertFromDecimal(convertToDecimal, toX);
        Console.WriteLine("Number:{0} converted from {1} in {2} numeral system is: ", numberToConvert, fromX, toX);
        Console.WriteLine(result);
    }

    static string ConvertFromDecimal(long number, int numeralSystem)
    {
        StringBuilder binaryArray = new StringBuilder();
        string result = "";
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
    static long ConvertToDecimal(string number, int fromX)
    {
        long[] convertedlArray = new long[number.Length];
        long result = 0;
        int numeralSystem = fromX;
        for (int i = number.Length - 1; i >= 0; i--)
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
        for (int j = number.Length - 1; j >= 0; j--)
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
}

