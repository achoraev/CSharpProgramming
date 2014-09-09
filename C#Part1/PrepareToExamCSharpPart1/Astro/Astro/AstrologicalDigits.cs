using System;
using System.Numerics;

class AstrologicalDigits
{
    static void Main()
    {
        string number = Console.ReadLine();
        int sum = 0;
        int temp = 0;
        int temp2 = 0;
        
        for (int i = 0; i < number.Length; i++)
        {
            if (number == "." || number == "=")
            {
                sum += int.Parse(number[i].ToString());
            }
                       
        }
        

        if (sum > 9)
        {
            for (int j = 0; j < 10; j++)
            {
                temp += sum % 10;
                sum /= 10;
            }
            if (temp > 9)
            {
                for (int j = 0; j < 5; j++)
                {
                    temp2 += temp % 10;
                    temp /= 10;
                }
                Console.WriteLine(temp2);
            }
            else
            {
                Console.WriteLine(temp);
            }
        }
        else
        {
            Console.WriteLine(sum);
        }
        
    }
}