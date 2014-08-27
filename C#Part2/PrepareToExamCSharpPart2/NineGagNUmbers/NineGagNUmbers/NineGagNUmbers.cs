using System;
using System.Text;
using System.Collections.Generic;
using System.Numerics;

class NineGagNUmbers
{
    static void Main()
    {
        string nineGagNumber = Console.ReadLine();
        StringBuilder text = new StringBuilder();
        StringBuilder nineGag = new StringBuilder();
        for (int i = 0; i < nineGagNumber.Length; i++)
        {
            text.Append(nineGagNumber[i]);
            switch (text.ToString())
            {
                case "-!": nineGag.Append("0"); text.Clear(); break;
                case "**": nineGag.Append("1"); text.Clear(); break;
                case "!!!": nineGag.Append("2"); text.Clear(); break;
                case "&&": nineGag.Append("3"); text.Clear(); break;
                case "&-": nineGag.Append("4"); text.Clear(); break;
                case "!-": nineGag.Append("5"); text.Clear(); break;
                case "*!!!": nineGag.Append("6"); text.Clear(); break;
                case "&*!": nineGag.Append("7"); text.Clear(); break;
                case "!!**!-": nineGag.Append("8"); text.Clear(); break;
                
                default:  break;
            }
        }        
        BigInteger result = ConvertToDecimal(nineGag.ToString());
        Console.WriteLine(result);
    }

    static BigInteger ConvertToDecimal(string number)
    {
        BigInteger[] convertedlArray = new BigInteger[number.Length];
        BigInteger result = 0;
        int numeralSystem = 9;
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
                default: convertedlArray[i] = BigInteger.Parse(number[i].ToString()); break;
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

