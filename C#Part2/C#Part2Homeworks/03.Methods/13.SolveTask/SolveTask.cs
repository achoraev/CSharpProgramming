using System;
using System.Collections.Generic;
/*Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0*/

class SolveTask
{
    static void Main()
    {
        Console.WriteLine("Enter your choice: ");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("1. Reverses the digits of a number");
        Console.WriteLine("2. Calculates the average of a sequence of integers");
        Console.WriteLine("3. Solves a linear equation a * x + b = 0");
        Console.WriteLine("---------------------------------------------------");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: ReverseDigit(); break;
            case 2: CalculateAverage(); break;
            case 3: LinearInput(); break;
            default: Console.WriteLine("Wrong choice!!!"); break;
        }
    }

    static void LinearInput()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("A must not be equal to Zero!");
        }
        else
        {
            Console.WriteLine("Equation result is: {0}", SolveEquation(a, b));
        }
    }

    static double SolveEquation(int a, int b)
    {
        return (double)-b / a;
    }

    static void CalculateAverage()
    {
        long[] array = { 1, 9, 5, 6, 100, 7, 55, 33, 12 };
        if (array.Length == 0)
        {
            Console.WriteLine("Array must not be empty!!!");
        }
        else
        {
            long result = 0;
            Console.WriteLine("Array is: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            for (int j = 0; j < array.Length; j++)
            {
                result += array[j];
            }
            result /= array.Length;
            Console.WriteLine();
            Console.WriteLine("Average is: {0}", result);      
        }   
    }

    static void ReverseDigit()
    {
        Console.WriteLine("Enter number to reverse: ");
        long number = long.Parse(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("Number must non negative!!!");
        }
        else
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
            Console.WriteLine("Reversed number is: ");
            for (int i = 0; i < reversedNumber.Count; i++)
            {
                Console.Write(reversedNumber[i]);
            }
            Console.WriteLine();   
        }      
    }
}
