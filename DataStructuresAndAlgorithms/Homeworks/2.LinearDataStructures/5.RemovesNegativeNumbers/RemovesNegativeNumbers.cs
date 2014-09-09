// 5.Write a program that removes from given sequence all negative numbers.
namespace RemovesNegativeNumbers
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
            List<int> sequence = new List<int>() { 1, 5, -6, 88, 99, -565, 654, 54, -99, 23, -132, 36 };
            sequence.RemoveAll(x => x < 0);
            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}