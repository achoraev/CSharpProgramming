namespace CatalogOfFreeContent
{
    using System;
    using System.Linq;

    public class CommandsOfContent : ICommand
    {
        private readonly char[] paramsSeparators = { ';' };

        private readonly char commandEnd = ':';

        private int commandNameEndIndex;

        public CommandsOfContent(string input)
        {
            this.OriginalForm = input.Trim();
            this.Parse();
        }

        public Commands Type { get; set; }

        public string OriginalForm { get; set; }

        public string Name { get; set; }

        public string[] Parameters { get; set; }                        

        public Commands ParseCommandType(string commandName)
        {
            Commands type;

            if (commandName.Contains(':') || commandName.Contains(';'))
            {
                throw new FormatException();
            }

            switch (commandName.Trim())
            {
                case "Add book": 
                    type = Commands.AddBook; 
                    break;

                case "Add movie": 
                    type = Commands.AddMovie; 
                    break;

                case "Add song":
                    type = Commands.AddSong;
                    break;

                case "Add application": 
                    type = Commands.AddApplication; 
                    break;

                case "Update":
                    type = Commands.Update; 
                    break;

                case "Find": 
                    type = Commands.Find; 
                    break;

                default:
                    {
                        if (commandName.ToLower().Contains("book")
                            || commandName.ToLower().Contains("movie")
                            || commandName.ToLower().Contains("song")
                            || commandName.ToLower().Contains("application"))
                        {
                            throw new InsufficientExecutionStackException();
                        }

                        if (commandName.ToLower().Contains("find")
                            || commandName.ToLower().Contains("update"))
                        {
                            throw new InvalidProgramException();
                        }

                        throw new MissingFieldException("Invalid command name!");
                    }
            }

            return type;
        }

        public string ParseName()
        {
            string name = this.OriginalForm.Substring(0, this.commandNameEndIndex + 1);
            return name;
        }

        public string[] ParseParameters()
        {
            int paramsLength = this.OriginalForm.Length - (this.commandNameEndIndex + 3);

            string paramsOriginalForm = this.OriginalForm.Substring(this.commandNameEndIndex + 3, paramsLength);

            string[] parameters = paramsOriginalForm.Split(this.paramsSeparators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < parameters.Length; i++)
            {
                parameters[i] = parameters[i];
            }

            return parameters;
        }

        public int GetCommandNameEndIndex()
        {
            int endIndex = this.OriginalForm.IndexOf(this.commandEnd) - 1;

            return endIndex;
        }        

        public override string ToString()
        {
            string toString = this.Name + " ";

            foreach (string param in this.Parameters)
            {
                toString += param + " ";
            }

            return toString;
        }

        private void Parse()
        {
            this.commandNameEndIndex = this.GetCommandNameEndIndex();
            this.Name = this.ParseName();
            this.Parameters = this.ParseParameters();
            this.TrimParams();
            this.Type = this.ParseCommandType(this.Name);
        }

        private void TrimParams()
        {
            for (int i = 0; i < this.Parameters.Length; i++)
            {
                // if (!(i < this.Parameters.Length))
                // {
                //    break;
                // }
                this.Parameters[i] = this.Parameters[i].Trim();
            }
        }
    }
}