using System;
//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is working correctly.

public class CountHowManyTimes
{
    public static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        int times = 1;
        int maxTimes = 1;
        int number = 0;

        HowManyTimes(array, ref times, ref maxTimes, ref number);
        //print sequence
        Console.WriteLine("Number {0} is most frequent number -> {1} times.", number, maxTimes);
    }

    public static void HowManyTimes(int[] array, ref int times, ref int maxTimes, ref int number)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    times++;
                    if (times > maxTimes)
                    {
                        maxTimes = times;
                        number = array[j];
                    }
                }
            }
            times = 1;
        }
    }
}