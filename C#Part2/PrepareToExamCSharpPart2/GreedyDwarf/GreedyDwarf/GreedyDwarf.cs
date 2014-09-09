using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

    class GreedyDwarf
    {
        static void Main()
        {
            // input
            string []valeyNumbers = Console.ReadLine().Split(new char [] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            int numberOfLines = int.Parse(Console.ReadLine());
            BigInteger result = 0;
            BigInteger max = -10000;
            for (int i = 0; i < numberOfLines; i++)
            {
                string [] pattern = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);                
                result = Collect(pattern, valeyNumbers);
                if (result > max)
                {
                    max = result; 
                }
            }            
            // result
            Console.WriteLine(max);
        }

        static BigInteger Collect(string[] pattern, string[] valeyNumbers)
        {                   
            bool[] visited = new bool[valeyNumbers.Length];
            BigInteger sum = BigInteger.Parse(valeyNumbers[0]);
            long index=0;
            for (int i = 0; i < pattern.Length; i++)
            {
                visited[0] = true;
                index += long.Parse(pattern[i].ToString());
                if (index < 0 || index >= valeyNumbers.Length)
                {
                    break;
                }
                if (visited[index])
                {
                    break;
                }
                else
                {
                    sum += long.Parse(valeyNumbers[index]);
                    visited[index] = true;
                    if (pattern.Length-1 == i)
                    {
                        i = -1;
                    }
                }                                
            }
            
            return sum;
        }
    }

