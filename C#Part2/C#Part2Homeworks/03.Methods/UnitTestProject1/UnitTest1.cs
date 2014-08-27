using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

public class HowManyTimes
{
    public static Random randomGenerator = new Random();

    public static int[] ArrayFill(int[] numbersArray)
    {
        for (int index = 0; index < numbersArray.Length; index++)
        {
            numbersArray[index] = randomGenerator.Next(0, 5);
        }
        return numbersArray;
    }

    public static void PrintArray(int[] numbersArray)
    {
        foreach (int number in numbersArray)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    public void Main()
    {
        int[] numbersArray = new int[randomGenerator.Next(4, 11)];
        int checkedNumber = randomGenerator.Next(0, 9);
        numbersArray = ArrayFill(numbersArray);
        PrintArray(numbersArray);
        //Console.WriteLine("Number {0} is met 1 times in the Array", checkedNumber, CountHowManyTimes.HowManyTimes(int[] numbersArray, ref int times, ref int maxTimes, ref int number));
    }
}


