using System;
//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints 
//the biggest of them using the method GetMax().

class MethodMaxNumber
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        int max = 0;
        max = firstNumber;
        if (secondNumber > firstNumber)
        {
            max = secondNumber;
        }
        return max;
    }

    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number: ");
        int second = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number: ");
        int third = int.Parse(Console.ReadLine());
        int temp = GetMax(first, second);
        int max = GetMax(temp, third);

        Console.WriteLine("The bigger number is: {0}", max);
    }
}