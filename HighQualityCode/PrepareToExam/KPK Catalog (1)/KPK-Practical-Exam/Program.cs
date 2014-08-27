namespace CatalogOfFreeContent
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Wintellect.PowerCollections;

    public class Program
    {
        public static void Main()
        {
            StringBuilder output = new StringBuilder();
			ca cat = new ca();
			ICommandExecutor c = new ce();

            foreach (ICommand item in parse())
            {
                c.ExecuteCommand(cat, item, output);
            }
            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(output);
        }

        private static List<ICommand> parse()
        {
            List<ICommand> ins = new List<ICommand>();
            bool end = false;
            do // to do new while
            {
                string l = Console.ReadLine();// to do trim 
                end = (l.Trim() == "End");
                if (!end)
                {
                    ins.Add(new com(l));
                }
            }
            while (!end);
            return ins;
        }
    }     
}