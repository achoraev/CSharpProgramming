using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit;
//the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.

    class AddDigitsInArray
    {
        static void Main()
        {
            Console.WriteLine("Enter positive number (up to 10 000 digits): ");// ne priema poveche ot 255 digits check it:
            // 1111111111111111111111222222222222222222222222222222222233333333333333333333333333333333333333333333333344444444444444444444444444444444444444444555555555555555555555555555555555555555555555555555556666666666666666666666666666666667777777777777777777777777777777777788888888888888888888888888888888888888888888888888888999999999999999999999999999999999    
            long[] firstArray = Console.ReadLine().ToCharArray().Select(c => long.Parse(c.ToString())).ToArray();
            long[] secondArray = Console.ReadLine().ToCharArray().Select(c => long.Parse(c.ToString())).ToArray();
            List<long> newNumber = SumOfTwoArrays(firstArray, secondArray);

            Console.Write("The result is: ");
            for (int i = 0; i < newNumber.Count(); i++)
            {
                Console.Write(newNumber[i]);
            }
            Console.WriteLine();
        }

        static List<long> SumOfTwoArrays(long[] numberOne, long[] numberTwo)
        {
            long[] longerNum;
            long[] shorterNum;
            if (numberOne.Length > numberTwo.Length)
            {
                longerNum = new long[numberOne.Length];
                shorterNum = new long[numberTwo.Length];
                for (int i = 0; i < longerNum.Length; i++)
                {
                    longerNum[i] = numberOne[i];
                }
                for (int i = 0; i < shorterNum.Length; i++)
                {
                    shorterNum[i] = numberTwo[i];
                }
            }
            else
            {
                longerNum = new long[numberTwo.Length];
                shorterNum = new long[numberOne.Length];
                for (int i = 0; i < longerNum.Length; i++)
                {
                    longerNum[i] = numberTwo[i];
                }
                for (int i = 0; i < shorterNum.Length; i++)
                {
                    shorterNum[i] = numberOne[i];
                }
                Array.Reverse(longerNum);
                Array.Reverse(shorterNum);
            }

            long carry = 0;
            long sum = 0;
            List<long> result = new List<long>();
            for (int i = 0; i < shorterNum.Length; i++)
            {
                sum = (long)(shorterNum[i] + longerNum[i] + carry);
                if (sum >= 10)
                {
                    carry = 1;
                    sum %= 10;
                    result.Add(sum);
                }
                else
                {
                    carry = 0;
                    result.Add(sum);
                }
            }

            for (int i = shorterNum.Length; i < longerNum.Length; i++)
            {
                sum = (long)(longerNum[i] + carry);
                if (sum >= 10)
                {
                    carry = 1;
                    sum %= 10;
                    result.Add(sum);
                }
                else
                {
                    carry = 0;
                    result.Add(sum);
                }
            }

            if (carry == 1)
            {
                result.Add(1);
            }
            result.Reverse();
            return result;
        }
    }

