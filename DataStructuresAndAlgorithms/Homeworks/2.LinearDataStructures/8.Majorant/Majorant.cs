// 8. The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times. Write a program to find the majorant of given array (if exists). 
// Example: {2, 2, 3, 3, 2, 3, 4, 3, 3}  3
namespace Majorant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Majorant
    {
        public static void Main()
        {
            int[] array = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3};

            var dict = array.GroupBy(x => x).ToDictionary(gr => gr.Key, gr => gr.Count());

            var majElement = array.FirstOrDefault(x => dict[x] >= array.Length / 2 + 1);

            Console.WriteLine(majElement == 0 ? "No majorant found!" : "The majorant element is {0}", majElement);
        }
    }
}