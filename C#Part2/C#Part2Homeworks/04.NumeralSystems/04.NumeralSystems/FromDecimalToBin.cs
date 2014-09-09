using System;
//Write a program to convert decimal numbers to their binary representation.

class FromDecimalToBin
{
    static int[] ConvertDecimalToBinary(int number)// raboti do 1023 treta zadacha raboti s poveche
    {
        int[] binaryArray = new int[9];
        for (int i = 0; i <= 8; i++)
        {
            binaryArray[i] = number % 2;
            number = number / 2;
            if (number == 0)
            {
                Array.Reverse(binaryArray);
                break;
            }
        }
        return binaryArray;
    }

    static void Main()
    {
        Console.WriteLine("Enter decimal number: ");
        int decimalNum = int.Parse(Console.ReadLine());
        int[] convertedArray = ConvertDecimalToBinary(decimalNum);
        Console.Write("Number in binary numerical system is: ");
        for (int i = 0; i < convertedArray.Length; i++)
        {
            Console.Write(convertedArray[i]);
        }
        Console.WriteLine();

    }
}