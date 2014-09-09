using System;
using System.Text;
using System.Collections.Generic;

class Zerg
{
    static void Main()
    {
        string message = Console.ReadLine();
        StringBuilder code = new StringBuilder();
        List<string> numberFifthteenNumeral = new List<string>();
        //read input and convert
        int count = 0;

        for (int i = 0; i < message.Length; i++)
        {
            for (int j = count; j < (count + 4); j++)
            {
                if (j < message.Length)
                {
                    code.Append(message[j]);
                }
            }
            switch (code.ToString())
            {
                case "Rawr": numberFifthteenNumeral.Add("0"); break;
                case "Rrrr": numberFifthteenNumeral.Add("1"); break;
                case "Hsst": numberFifthteenNumeral.Add("2"); break;
                case "Ssst": numberFifthteenNumeral.Add("3"); break;
                case "Grrr": numberFifthteenNumeral.Add("4"); break;
                case "Rarr": numberFifthteenNumeral.Add("5"); break;
                case "Mrrr": numberFifthteenNumeral.Add("6"); break;
                case "Psst": numberFifthteenNumeral.Add("7"); break;
                case "Uaah": numberFifthteenNumeral.Add("8"); break;
                case "Uaha": numberFifthteenNumeral.Add("9"); break;
                case "Zzzz": numberFifthteenNumeral.Add("A"); break;
                case "Bauu": numberFifthteenNumeral.Add("B"); break;
                case "Djav": numberFifthteenNumeral.Add("C"); break;
                case "Myau": numberFifthteenNumeral.Add("D"); break;
                case "Gruh": numberFifthteenNumeral.Add("E"); break;
            }
            code.Clear();
            count += 4;
        }
        // convert to decimal
        string result = string.Empty;
        for (int i = 0; i < numberFifthteenNumeral.Count; i++)
        {
            result += numberFifthteenNumeral[i];
        }
        long resultInDecimal = ConvertAnyToDecimal(result);

        //print
        Console.WriteLine(resultInDecimal);
    }
    static long ConvertAnyToDecimal(string number)
    {
        long[] convertedlArray = new long[number.Length];
        long result = 0;
        int numeralSystem = 15;
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