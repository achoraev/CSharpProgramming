namespace CatalogOfFreeContent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class CommandExecutor : ICommandExecutor
    {
        public void ExecuteCommand(ICatalog catalogOfContent, ICommand command, StringBuilder output)
        {
            switch (command.Type)
            {
                case Commands.AddBook:
                    catalogOfContent.Add(new CompareContent(Content.Book, command.Parameters));
                    output.AppendLine("Book added");
                    break;

                case Commands.AddMovie:
                    catalogOfContent.Add(new CompareContent(Content.Movie, command.Parameters));
                    output.AppendLine("Movie added");
                    break;

                case Commands.AddSong:
                    catalogOfContent.Add(new CompareContent(Content.Song, command.Parameters));
                    output.AppendLine("Song added");
                    break;

                case Commands.AddApplication:
                    catalogOfContent.Add(new CompareContent(Content.Application, command.Parameters));
                    output.AppendLine("Application added");
                    break;

                case Commands.Update:
                    UpdateParameters(catalogOfContent, command, output);
                    break;

                case Commands.Find:
                    FindParameters(catalogOfContent, command, output);
                    break;

                default:
                    throw new ArgumentException("Unknown command!");
            }
        }

        private static void UpdateParameters(ICatalog catalogOfContent, ICommand command, StringBuilder output)
        {
            if (command.Parameters.Length != 2)
            {
                throw new FormatException("Invalid parameters!!");
            }

            int updatedContent = catalogOfContent.UpdateContent(command.Parameters[0], command.Parameters[1]);
            output.AppendLine(string.Format("{0} items updated", updatedContent));
        }

        private static void FindParameters(ICatalog catalogOfContent, ICommand command, StringBuilder output)
        {
            if (command.Parameters.Length != 2)
            {               
                throw new Exception("Invalid number of parameters!");
            }

            int numberOfElementsToList = int.Parse(command.Parameters[1]);

            IEnumerable<IContent> foundContent = catalogOfContent.GetListContent(command.Parameters[0], numberOfElementsToList);

            if (foundContent.Count() != 0)
            {
                foreach (IContent content in foundContent)
                {
                    output.AppendLine(content.TextRepresentation);
                }                
            }
            else
            {
                output.AppendLine("No items found");
            }
        }
    }
}
