// 1.Implement a class PriorityQueue<T> based on the data structure "binary heap".
namespace ImplementPriorityQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ImplementPriorityQueue
    {
        public static void Main()
        {
            var items = new[] { 2, 6, 3, 2, 1, 7, 4, 9, 5, 1, 8 };
            Console.WriteLine("Items: [{0}]", string.Join(", ", items));

            var queue = new PriorityQueue<int>();

            var minItem = int.MaxValue;
            foreach (var item in items)
            {
                queue.Enqueue(item);
                minItem = Math.Min(item, minItem);                
            }

            var sorted = new List<int>();
            while (queue.Count > 0)
            {
                sorted.Add(queue.Dequeue());
            }

            // sorted in ascending order
            Console.WriteLine("Queue items: [{0}]", string.Join(", ", sorted));
        }
    }
}