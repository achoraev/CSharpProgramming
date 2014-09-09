// 10.* We are given numbers N and M and the following operations:
// N = N+1
// N = N+2
// N = N*2
// Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M. Hint: use a queue.
// Example: N = 5, M = 16
// Sequence: 5 - 7 - 8 - 16
namespace ShortestSequenceBetweenNAndM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            Queue<int> queue = new Queue<int>();

            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter M:");
            int m = int.Parse(Console.ReadLine());

            queue.Enqueue(n);

            int stepCounter = 0;

            StringBuilder sb = new StringBuilder();

            while (stepCounter <= m)
            {
                stepCounter++;
                int numToOperateOn = queue.Dequeue();                
                sb.Append(numToOperateOn);
                sb.Append("-");

                if (numToOperateOn >= m)
                {
                    break;
                }

                numToOperateOn = numToOperateOn + 1;
                queue.Enqueue(numToOperateOn);
                numToOperateOn = numToOperateOn + 2;
                queue.Enqueue(numToOperateOn);
                numToOperateOn = numToOperateOn * 2;
                queue.Enqueue(numToOperateOn);
            }

            sb.Length--;

            Console.WriteLine(sb);
        }
    }
}
