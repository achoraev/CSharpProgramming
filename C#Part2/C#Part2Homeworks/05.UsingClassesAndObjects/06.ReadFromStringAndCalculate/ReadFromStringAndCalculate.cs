using System;
//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum. 
//Example: string = "43 68 9 23 318" -> result = 461

class ReadFromStringAndCalculate
{
    static void Main()
    {
        string numbers = "43 68, 9/ 23 ,/  318";
        numbers = ReadString(numbers).ToString();
        Console.WriteLine("The sum is: {0}", numbers);
    }

    private static long ReadString(string numbers)
    {
        string[] num;
        long result = 0;
        num = numbers.Split(new char[] { ' ', ',', '-', '/' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < num.Length; i++)
        {
            result += int.Parse(num[i]);
        }
        return result;
    }
}

