using System;
using System.Collections.Generic;
//Write a method that reverses the digits of given decimal number. Example: 256  652

class ReverseDigit
{
    static List<long> RevDigitMethod(long number)
    {
        List<long> reversedNumber = new List<long>();
        for (int i = 0; i < 100; i++)// Check 100 digits if u want more correct number.
        {
            long temp = number % 10;            
            reversedNumber.Add(temp);
            number /= 10;
            if (number == 0)
            {
                break;
            }
        }
        return reversedNumber;
    }
    
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        long decimalNum = long.Parse(Console.ReadLine());
        List<long> reversedList = RevDigitMethod(decimalNum);
        for (int i = 0; i < reversedList.Count; i++)
        {
            Console.Write(reversedList[i]);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

