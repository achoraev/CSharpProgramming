using System;
using System.Text;
//Write a program to convert binary numbers to their decimal representation.

class FromBinToDecimal
{
    static long ConvertBinToDecimal(long number, int numeralSystem)
    {        
        long result = 0;
        for (int i = 0; i < 10000 ; i++)
        {
            if (number%10 == 0)
            {                
                number /= 10;
                continue;
            }
            else
            {
                result += (number % 10) * PovdiganeNaStepen(numeralSystem, i);
                number /= 10;
                if (number==0)
                {
                    break;
                }
            }            
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

    static void Main()
    {
        Console.WriteLine("Enter binary number: ");
        long binaryNum = long.Parse(Console.ReadLine());        
        int numeralSystem = 2;       
        long convertedNum = ConvertBinToDecimal(binaryNum, numeralSystem);
        Console.Write("Number in decimal numerical system is: {0}", convertedNum);        
        Console.WriteLine();
    }
}