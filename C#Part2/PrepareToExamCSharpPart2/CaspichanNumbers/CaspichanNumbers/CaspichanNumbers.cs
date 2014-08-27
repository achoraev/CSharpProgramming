using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CaspichanNumbers
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        List<string> digits = new List<string>();
        digits = ConvertNumber(number, digits);
        string result = string.Empty;
        if (number==0)
        {
            Console.WriteLine("A");
        }
        while (number != 0)
        {
            ulong index = number % 256;
            result = digits[(int)index]+result;
            number /= 256;
        }
        Console.WriteLine(result);

    }

    static List<string> ConvertNumber(ulong number, List<string> digits)
    {
        
        for (char i = 'A'; i <= 'Z'; i++)
        {
            digits.Add(i.ToString());
        }

        for (char i = 'a'; i <= 'i'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                digits.Add(i.ToString()+j.ToString());
            } 
        }
        return digits;
    }
}

