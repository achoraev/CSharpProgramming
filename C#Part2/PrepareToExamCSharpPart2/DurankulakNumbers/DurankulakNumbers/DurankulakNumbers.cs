using System;
using System.Collections.Generic;
using System.Text;

class DurankulakNumbers
{
    static void Main()
    {
        string number = Console.ReadLine();
        ulong result = ConvertFromBase(number, 168);
        Console.WriteLine(result);
    }

    private static ulong ConvertFromBase(string number, ulong numberBase)
    {
        ulong sum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            int digit;
            if (char.IsUpper(number[i]))
            {
                digit = number[i] - 'A';
            }
            else
            {
                digit = (number[i] - 'a' + 1) * 26 + number[i + 1] - 'A';
                i++;
            }
            sum = sum * numberBase + (ulong)digit;
        }
        return sum;
    }
}

