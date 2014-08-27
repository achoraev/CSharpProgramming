using System;
using System.Text;
using System.Collections.Generic;

    class MultiverseCommunication
    {	
    static void Main()
        {
        string message = Console.ReadLine();
        StringBuilder code = new StringBuilder ();
        List <string> numberThirthteenNumeral = new List<string>();
        //read input and convert
        int count = 0;

        for (int i = 0; i < message.Length; i++)
        {
            for (int j = count; j < (count + 3); j++)
            {
                if (j < message.Length)
                {
                    code.Append(message[j]);
                }                
            }
            switch (code.ToString())
            {
                case "CHU": numberThirthteenNumeral.Add("0"); break;
                case "TEL": numberThirthteenNumeral.Add("1"); break;
                case "OFT": numberThirthteenNumeral.Add("2"); break;
                case "IVA": numberThirthteenNumeral.Add("3"); break;
                case "EMY": numberThirthteenNumeral.Add("4"); break;
                case "VNB": numberThirthteenNumeral.Add("5"); break;
                case "POQ": numberThirthteenNumeral.Add("6"); break;
                case "ERI": numberThirthteenNumeral.Add("7"); break;
                case "CAD": numberThirthteenNumeral.Add("8"); break;
                case "K-A": numberThirthteenNumeral.Add("9"); break;
                case "IIA": numberThirthteenNumeral.Add("A"); break;
                case "YLO": numberThirthteenNumeral.Add("B"); break;
                case "PLA": numberThirthteenNumeral.Add("C"); break;
            }
            code.Clear();
            count += 3; 
        }        
        // convert to decimal
        string result = "";
        for (int i = 0; i < numberThirthteenNumeral.Count; i++)
        {
            result += numberThirthteenNumeral[i]; 
        }
        long resultInDecimal = ConvertAnyToDecimal(result);
        
        //print
        Console.WriteLine(resultInDecimal);
        }
        static long ConvertAnyToDecimal(string number)
        {
            long[] convertedlArray = new long[number.Length];
            long result = 0;
            long numeralSystem = 13;
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
                result += convertedlArray[j] * (long)Math.Pow((double)numeralSystem, (double)j);
            }
            return result;
        }
    }