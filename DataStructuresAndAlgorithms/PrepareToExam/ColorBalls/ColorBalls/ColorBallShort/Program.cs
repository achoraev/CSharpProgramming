using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Program
{
    static char[] inputLetters;
    static BigInteger[] factorials;

    public static void Main()
    {
        BigInteger denominator = 1;
        Dictionary<char, int> letters = new Dictionary<char, int>();       
        inputLetters = Console.ReadLine().ToArray();
        factorials = new BigInteger[inputLetters.Length + 1];
        CountFactorial();
       
        for (int i = 0; i < inputLetters.Length; i++)
        {
            if (!letters.ContainsKey(inputLetters[i]))
            {
                letters.Add(inputLetters[i], 1);
            }
            else
            {
                letters[inputLetters[i]]++;
            }
        }

        foreach (var letter in letters)
        {
            denominator *= factorials[letter.Value];
        }
        // result
        Console.WriteLine(factorials[inputLetters.Length] / denominator);
    }

    private static void CountFactorial()
    {
        factorials[0] = 0;
        factorials[1] = 1;        

        for (int i = 2; i <= inputLetters.Length; i++)
        {
            factorials[i] = i * factorials[i - 1];
        }
    }
}