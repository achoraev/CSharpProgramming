namespace CatalogOfFreeContent
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Wintellect.PowerCollections;
		
	public class ce : ICommandExecutor
    {
        public void ExecuteCommand(ICatalog contCat, ICommand c, StringBuilder sb)
        {
            switch (c.Type)
            {
                case comt.AddBook:
                    {
                        contCat.Add(new co(ct.Kniga, c.Parameters));
						sb.AppendLine("Books Added");
                    }
					break;

                case comt.AddMovie:
                    {
                        contCat.Add(new co(ct.Film, c.Parameters));
                        sb.AppendLine("Movie added");
                    }
                    break;

                case comt.AddSong:
                    {
                        contCat.Add(new co(ct.Muzika, c.Parameters));
                        sb.Append("Song added");
                    }
                    break;

                case comt.AddApplication:
                    {                        
                        contCat.Add(new co(ct.Prilozenie, c.Parameters));
                        sb.AppendLine("Application added");
                    }
                    break;

                case comt.Update:
                    {
                        if (c.Parameters.Length == 2)
                        {
                            
                        }
                        else
                        {
                            throw new FormatException("невалидни параметри!");
                        }
                        sb.AppendLine(String.Format("{0} items updated", contCat.UpdateContent(c.Parameters[0], c.Parameters[1]) - 1));
                    }
                    break;

                case comt.Find:
                    {
                        if (c.Parameters.Length != 2)
                        {
                            Console.WriteLine("Invalid params!");
                            throw new Exception("Invalid number of parameters!");
                        }
						
                        Int32 numberOfElementsToList = Int32.Parse(c.Parameters[1]);

                        IEnumerable<IContent> foundContent = contCat.GetListContent(c.Parameters[0], numberOfElementsToList);

                        if (foundContent.Count() == 0)
                        {
                            sb.AppendLine("No items found");
                        }
                        else
                        {
                            foreach (IContent content in foundContent)
                            {
                                sb.AppendLine(content.TextRepresentation);
                            }
                        }
                    }
                    break;

                default:
                    {
                        throw new InvalidCastException("Unknown command!");
                    }
            }
        }
    }
}