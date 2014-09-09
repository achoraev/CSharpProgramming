// 2.Write a program that reads N integers from the console and reverses them using a stack. Use the Stack<int> class.
namespace ReverseWithStack
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class ReverseWithStack
    {
        public static void Main()
        {
            Stack<int> inputStack = new Stack<int>();
            Console.WriteLine("Choice how much numbers....");
            int inputCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputCount; i++)
            {
                Console.WriteLine("Enter number... {0}", i + 1);
                int input = int.Parse(Console.ReadLine());
                inputStack.Push(input);
            }

            int count = inputStack.Count;
            Console.WriteLine("Reversed numbers: ");           

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(inputStack.Peek().ToString());
                inputStack.Pop();
            }
        }
    }
}