using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VariableLength
{
    static void Main()
    {
        // input
        List<int> inputFirstRow = new List<int>();
        string [] input = Console.ReadLine().TrimEnd().Split(new char [] {' '},StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < input.Length; i++)
        {
            inputFirstRow.Add(int.Parse(input[i]));
        }
        int numberOfLines = int.Parse(Console.ReadLine());
        StringBuilder code = new StringBuilder();
        for (int i = 0; i < numberOfLines; i++)
        {
            code.Append(Console.ReadLine().TrimEnd());
        }
        
        //solution
        StringBuilder encodedNumbers = new StringBuilder();
        // append converted from decimal to binary
        for (int i = 0; i < inputFirstRow.Count; i++)
        {
            encodedNumbers.Append(ConvertFromDecimal(inputFirstRow[i], 2).PadLeft(8, '0'));
        }
        //remove zeroes
        for (int i = encodedNumbers.Length - 1; i >= 0; i--)
        {
            if (encodedNumbers[i] == '0' && encodedNumbers[i - 1] != '1')
            {
                encodedNumbers.Remove(i, 1);
            }
            else
            {
                break;
            }
        }
        // count binary code and encode
        int count = 0;
        StringBuilder finalResult = new StringBuilder();
        for (int i = 0; i < encodedNumbers.Length; i++)
        {
            if (encodedNumbers[i] == '1')
            {
                count++;
                continue;
            }
            else if (encodedNumbers[i] == '0')
            {
                finalResult.Append(Decoder(code, count));
                count = 0;
            }            
        }
        
        //print
        for (int i = 0; i < finalResult.Length; i++)
        {
            Console.Write(finalResult[i]);
        }
        Console.WriteLine();

    }

    static string Decoder(StringBuilder code, int count)
    {
        string result = string.Empty;
        //char symbol = (char)count; 
        for (int i = 1; i < code.Length; i++)
        {
            if (code[i].ToString() == count.ToString())
            {
                result = code[i - 1].ToString();
                break;
            }
            else if (i < code.Length-1 && (code[i].ToString()+code[i+1].ToString()) == count.ToString())
            {
                result = code[i - 1].ToString();
                i++;
                break;
            }
            else
            {
                continue;
            }
        }
        
        return result;
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
        for (int i = binaryArray.Length - 1; i >= 0; i--)
        {
            result.Append(binaryArray[i]);
        }
        string final = result.ToString();
        return final;
    }
}

