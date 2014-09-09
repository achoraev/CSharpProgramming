using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

class BunnyFactory
{
    static void Main()
    {
        // input
        List<BigInteger> array = new List<BigInteger>();
        BigInteger input = 0;
        while (true)
        {
            try
            {
                input = BigInteger.Parse(Console.ReadLine().TrimEnd());
            }
            catch (Exception)
            {
                break;
            }
            array.Add(input);
        }
        // solution
        BigInteger length = array[0];
        List<BigInteger> result = new List<BigInteger>();
        if (length > array.Count)
        {
            Print(array);
        }
        else
        {
            array.RemoveAt(0);
            long startPosition = 0;
            result = MultiplicationProcess(array, length, startPosition);
            Print(result);
        }

    }

    private static void Print(List<BigInteger> result)
    {
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i]);
            if (i < result.Count - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }

    static List<BigInteger> MultiplicationProcess(List<BigInteger> array, BigInteger length, BigInteger startPosition)
    {
        StringBuilder currentArray = new StringBuilder();
        BigInteger sum = 0;
        BigInteger product = 1;
        int index = 0;

        if (length > array.Count)
        {
            return array;
        }
        else
        {
            SumAndProduct(array, ref length, ref startPosition, ref sum, ref product, ref index);
            currentArray.Append(sum);
            currentArray.Append(product);
            for (int i = index; i < array.Count; i++)
            {
                currentArray.Append(array[i]);
            }
            for (int i = 0; i < currentArray.Length; i++)
            {
                if (currentArray[i] == '1' || currentArray[i] == '0')
                {
                    currentArray.Remove(i, 1);
                    i--;
                }
            }
        }
        List<BigInteger> final = new List<BigInteger>();
        for (int i = 0; i < currentArray.Length; i++)
        {
            final.Add(BigInteger.Parse(currentArray[i].ToString()));
        }
        length = 0;
        for (int i = 0; i < final[0]; i++)
        {
            if (i < final.Count)
            {
                length += final[i];
            }
            else
            {
                return final;
            }
        }
        startPosition = final[0];
        final = MultiplicationProcess(final, length, startPosition);//recursion
        return final;
    }

    private static void SumAndProduct(List<BigInteger> array, ref BigInteger length, ref BigInteger startPosition, ref BigInteger sum, ref BigInteger product, ref int index)
    {
        for (int i = (int)startPosition; i < length + startPosition; i++)
        {
            sum += array[i];
            product *= array[i];
            index = i + 1;
        }
    }
}