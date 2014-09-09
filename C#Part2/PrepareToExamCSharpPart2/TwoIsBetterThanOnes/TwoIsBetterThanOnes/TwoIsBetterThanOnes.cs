using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TwoIsBetterThanOnes
{
    static void Main()
    {
        //read input
        string[] input = Console.ReadLine().Split();
        long numberA = long.Parse(input[0]);
        long numberB = long.Parse(input[1]);
        string[] secondTask = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int percent = int.Parse(Console.ReadLine());
        //first task
        int result = 0;
        List<long> palindromeNumbers = new List<long>();
        result = FindNumberOfLuckyNumber(numberA, numberB);
        // too slow time limit
        //for (long i = numberA; i < numberB; i++) 
        //{
        //    if (CheckIsPalindrome(i))
        //    {
        //        palindromeNumbers.Add(i);                
        //    }            
        //}
        //for (int i = 0; i < palindromeNumbers.Count; i++)
        //{
        //    if (CheckLuckyNums((long)i))
        //    {
        //        result++;
        //    }
        //}
        //second task
        int [] listOfNumbers = new int [secondTask.Length];
        int posOfNumberInList = 0;
        int resultSecond = 0;
        for (int i = 0; i < secondTask.Length; i++)
        {
            listOfNumbers[i] = int.Parse(secondTask[i]);
        }
        Array.Sort(listOfNumbers);
        posOfNumberInList = (int)Math.Ceiling((decimal)(listOfNumbers.Length * percent) / 100);
        if (posOfNumberInList == 0)
        {
            resultSecond = listOfNumbers[posOfNumberInList];
        }
        else if (posOfNumberInList > listOfNumbers.Length-1)
        {
            resultSecond = listOfNumbers[posOfNumberInList-1];
        }
        else
        {
            if (listOfNumbers[posOfNumberInList] >= listOfNumbers[posOfNumberInList - 1])
            {
                resultSecond = listOfNumbers[posOfNumberInList - 1];
            }
            else
            {
                resultSecond = listOfNumbers[posOfNumberInList];
            } 
        }

        //print 
        Console.WriteLine(result);
        Console.WriteLine(resultSecond);

    }

    private static int FindNumberOfLuckyNumber(long lowerBound, long upperBound)
    {
        long maxNumber = upperBound;

        int left = 0;
        var numbers = new List<long> { 3, 5 }; // We are using "numbers" as a Queue

        while (left < numbers.Count)
        {
            int right = numbers.Count;
            for (int i = left; i < right; i++)
            {
                if (numbers[i] <= maxNumber)
                {
                    numbers.Add((numbers[i] * 10) + 3);
                    numbers.Add((numbers[i] * 10) + 5);
                }
            }

            left = right;
        }

        int count = 0;
        foreach (var number in numbers)
        {
            if (number >= lowerBound && number <= upperBound && CheckIsPalindrome(number))
            {
                count++;
            }
        }

        return count;
    } 

    static bool CheckIsPalindrome(long number)
    {
        string num = number.ToString();
        for (int i = 0; i < num.Length/2; i++)
        {
            if (num[i] != num[num.Length - i -1])
            {
                return false;
            }
        }
        return true;        
    }

    static bool CheckLuckyNums(long number)
    {
        string num = number.ToString();
        for (int i = 0; i <= num.Length/2; i++)
        {
            if (num[i] == '3' || num [i] == '5')
            {
                return true;
            }
        }        
        return false;
    }
}

