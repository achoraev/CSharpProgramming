using System;
using System.Collections.Generic;
//* We are given an array of integers and a number S. 
//Write a program to find if there exists a subset of the elements of the array that has a sum S.
// Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)

class SubsetOfElements
{
    static void Main()
    {
        int[] numbers = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int number = 14;
        int tempSum = 0;        
        //bool haveSequence = false;
        Array.Sort(numbers);
        for (int i = numbers.Length; i > 0; i--)
        {            
            tempSum += numbers[i-1];
            
            if (tempSum == number)
            {                
                Console.WriteLine("{0}",numbers[i - 1]);
                Console.WriteLine("yes");
                break;
            }
            else if (tempSum > number)
            {
                tempSum -= numbers[i - 1];
                
            }
            else
            {
                Console.Write("{0}+", numbers[i - 1]);
            }
        }

        //List<int> position = new List <int>();
        
        //for (int i = 0; i < numbers.Length-1; i++)
        //{
        //    tempSum += numbers[i];
        //    position.Add(i);
        //    if (tempSum == number)
        //    {
        //        position.Add(i);
        //        haveSequence = true;
        //        break;
        //    }
        //    for (int j = 1; j < numbers.Length; j++)
        //    {                
        //        tempSum += numbers[j];
        //        if (tempSum == number)
        //        {
        //            position.Add(j);
        //            haveSequence = true;
        //            break;
        //        }
        //        else if (tempSum > number)
        //        {
        //            tempSum = numbers[i];                     
        //        }
        //    }
        //}
        //print sequence        
        //Console.Write("Sum {0}", number);
        //Console.WriteLine();
        //if (haveSequence)
        //{
        //    for (int i = 0; i < position.Count; i++)
        //    {
        //        Console.Write("{0}", numbers[position[i]]);
        //        if (i != position.Count)
        //        {
        //            Console.Write("+");
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("No Sequence!!!");
        //}
        //Console.WriteLine();
    }
}