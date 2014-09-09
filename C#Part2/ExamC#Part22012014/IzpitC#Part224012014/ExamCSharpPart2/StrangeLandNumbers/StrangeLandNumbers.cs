using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class StrangeLandNumbers
{
    static void Main()
    {
        //read input
        string input = Console.ReadLine().TrimEnd();

        //solution
        StringBuilder inputCode = new StringBuilder();
        StringBuilder finalResult = new StringBuilder();
        long result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            inputCode.Append(input[i]);
            
            switch (inputCode.ToString())
            {
                case "f": finalResult.Append(0); inputCode.Clear(); break;
                case "bIN": finalResult.Append(1); inputCode.Clear(); break;
                case "oBJEC": finalResult.Append(2); inputCode.Clear(); break;
                case "mNTRAVL": finalResult.Append(3); inputCode.Clear(); break;
                case "lPVKNQ": finalResult.Append(4); inputCode.Clear(); break;
                case "pNWE": finalResult.Append(5); inputCode.Clear(); break;
                case "hT": finalResult.Append(6); inputCode.Clear(); break;                
                default: break;
            }           
        }
        result = ConvertToDecimal(finalResult.ToString(), 7);
        // print result
        Console.WriteLine(result);
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