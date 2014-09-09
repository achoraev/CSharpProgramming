namespace CatalogOfFreeContent
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class CatalogEntry
    {
        private const string TestIn001 = @"Find: One; 3
Add application: Firefox v.11.0; Mozilla; 16148072; http://www.mozilla.org 
Add book: Intro C#; S.Nakov; 12763892; http://www.introprogramming.info
Add song: One; Metallica; 8771120; http://goo.gl/dIkth7gs
Add movie: The Secret; Drew Heriot, Sean Byrne & others (2006); 832763834; http://t.co/dNV4d
Find: One; 1
Add movie: One; James Wong (2001); 969763002; http://www.imdb.com/title/tt0267804/
Find: One; 10
Update: http://www.introprogramming.info; http://introprograming.info/en/
Find: Intro C#; 1
Update: http://nakov.com; sftp://www.nakov.com
End";

        public static void Main()
        {
            // todo comment this
            Console.SetIn(new StringReader(TestIn001));

            StringBuilder output = new StringBuilder();
            Catalog catalogOfContent = new Catalog();
            ICommandExecutor inputCommands = new CommandExecutor();

            var commands = Parse();
            foreach (ICommand item in commands)
            {
                inputCommands.ExecuteCommand(catalogOfContent, item, output);
            }

            Console.Write(output);
        }

        private static List<ICommand> Parse()
        {
            List<ICommand> listOfLines = new List<ICommand>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine.Trim() == "End")
                {
                    break;
                }  
              
                listOfLines.Add(new CommandsOfContent(inputLine));                
            }
            
            return listOfLines;
        }
    }
}