namespace SupermarketQueue
{
    using System;
    using System.Linq;
    using System.Text;
    using Wintellect.PowerCollections;
    using System.Diagnostics;

    public class SupermarketQueue
    {
        static BigList<string> QueueOfPeople = new BigList<string>();
        static StringBuilder result = new StringBuilder();
        public static void Main()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(DateTime.Now);
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "End")
                {
                    break;
                }

                switch (input[0])
                {
                    case "Append": AppendPerson(input[1]); break;
                    case "Serve": ServePeople(int.Parse(input[1])); break;
                    case "Find": Find(input[1]); break;
                    case "Insert": InsertPeople(int.Parse(input[1]), input[2]); break;
                }                
            }

            Console.WriteLine(result);
            sw.Stop();
            Console.WriteLine(DateTime.Now);
        }

        private static void InsertPeople(int position, string name)
        {            
            if (position <= QueueOfPeople.Count())
            {
                QueueOfPeople.Insert(position, name);

                result.AppendLine("OK");
            }
            else
            {
                result.AppendLine("Error");
            }            
        }

        private static void Find(string p)
        {
            int count = QueueOfPeople.Count(x => x == p);
            
            result.AppendLine(count.ToString());
        }

        private static void ServePeople(int count)
        {
            StringBuilder temp = new StringBuilder();
            if (count > QueueOfPeople.Count)
            {
                result.AppendLine("Error");
            }
            else
            {                
                for (int i = 0; i < count; i++)
                {
                    temp.Append(QueueOfPeople[i]);
                    temp.Append(" ");
                }

                QueueOfPeople.RemoveRange(0, count);
                
                result.AppendLine(temp.ToString());
            }
        }

        private static void AppendPerson(string Name)
        {
            QueueOfPeople.Add(Name);
            result.AppendLine("OK");
        }
    }
}