using System;
//Write a program that finds the most frequent number in an array. 
//Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

class MostFrequentNumber
{
    static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        int times = 1;
        int maxTimes = 1;
        int number = 0;

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
        //print sequence
        Console.WriteLine("Number {0} is most frequent number -> {1} times.", number, maxTimes);
    }
}