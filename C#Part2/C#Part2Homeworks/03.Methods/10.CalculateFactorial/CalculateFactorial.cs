using System;
using System.Collections.Generic;
using System.Numerics;
//Write a program to calculate n! for each n in the range [1..100]. Hint:
//Implement first a method that multiplies a number represented as array of digits by given integer number. 

    class CalculateFactorial
    {
        static BigInteger CalcFactorialForN(int[] array, int number)
        {
            BigInteger result = 1;
            for (int i = 1; i < array[number]-1; i++)
            {
                result *= array[i];
            }

            return result;
        }
        
        static void Main()
        {
            int [] numbers = new int [101];
            for (int i = 0; i < 101; i++)
            {
                numbers[i] = i+1;
            }
            Console.WriteLine("Enter number from 1 to 100: ");
            int num = int.Parse(Console.ReadLine());
            BigInteger numberFactorial = 0;
            numberFactorial = CalcFactorialForN(numbers, num);
            Console.WriteLine("Factorial is: {0} ", numberFactorial);
            //second variant print all factorial from 1 to 100
            for (int i = 1; i <= num; i++)
            {
                numberFactorial = CalcFactorialForN(numbers, i);
                Console.WriteLine("Factorial of {0,2} is: {1} ", i, numberFactorial);
            }
        }
    }

