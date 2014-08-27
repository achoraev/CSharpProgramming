using System;
// 05. You are given an array of strings. Write a method that sorts the array 
// by the length of its elements (the number of characters composing them).

class SortStrings
{
    static void Main()
    {        
        string[] beers = { "astika", "zagorka", "Zagorka", "heineken", "Ariana", "beer", "mastika" };
        SortingMethod(beers);
        foreach (var item in beers)
        {
            Console.WriteLine(item);
        }
    }

    static void SortingMethod(string[] array)
    {
        int[] stringsLenghts = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            stringsLenghts[i] = array[i].Length;
        }
        Array.Sort(stringsLenghts, array);
       return;
    }
}
