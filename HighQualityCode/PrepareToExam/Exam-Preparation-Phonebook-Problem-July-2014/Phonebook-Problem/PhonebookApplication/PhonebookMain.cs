namespace PhonebookApplication
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class PhonebookMain
    {
        private const string CountryCode = "+359";

        private static IPhonebookRepository data = new PhonebookRepository();

        private static StringBuilder output = new StringBuilder();

        public static void Main()
        {
            while (true)
            {
                string inputData = Console.ReadLine();
                if (inputData == "End" || inputData == null)
                {
                    break;
                }

                int index = inputData.IndexOf('(');
                if (index == -1)
                {
                    throw new ArgumentException("Invalid input");
                }

                string inputCommand = inputData.Substring(0, index);
                if (!inputData.EndsWith(")"))
                {
                    throw new ArgumentException("Invalid input");
                }
                string arguments = inputData.Substring(index + 1, inputData.Length - index - 2);
                string[] argumentsAsString = arguments.Split(',');
                for (int j = 0; j < argumentsAsString.Length; j++)
                {
                    argumentsAsString[j] = argumentsAsString[j].Trim();
                }

                if (inputCommand.StartsWith("AddPhone") && (argumentsAsString.Length >= 2))
                {
                    Command("AddPhone", argumentsAsString);
                }
                else if (inputCommand == "ChangePhone" && (argumentsAsString.Length == 2))
                {
                    Command("ChangePhone", argumentsAsString);
                }
                else if ((inputCommand == "List") && (argumentsAsString.Length == 2))
                {
                    Command("List", argumentsAsString);
                }
                else
                {
                    throw new ArgumentException("Invalid command");
                }
            }

            Console.Write(output);
        }

        private static void Command(string command, string[] strings)
        {
            if (command == "AddPhone")
            {
                string name = strings[0];
                var parameters = strings.Skip(1).ToList();
                for (int i = 0; i < parameters.Count; i++)
                {
                    parameters[i] = ConvertToKannonical(parameters[i]);
                }
                bool flag = data.AddPhone(name, parameters);

                if (flag)
                {
                    Print("Phone entry created");
                }
                else
                {
                    Print("Phone entry merged");
                }
            }
            else if (command == "ChangePhone")
            {
                string oldNumber = ConvertToKannonical(strings[0]);
                string newNumber = ConvertToKannonical(strings[1]);
                int changedNumber = data.ChangePhone(oldNumber, newNumber);
                string output = changedNumber + " numbers changed";
                Print(output);
            }
            else if (command == "List")
            {
                try
                {
                    IEnumerable<CompareNames> entries = data.ListEntries(int.Parse(strings[0]), int.Parse(strings[1]));
                    foreach (var entry in entries)
                    {
                        Print(entry.ToString());
                    }
                }
                catch
                {
                    Print("Invalid range");
                }
            }
        }

        private static string ConvertToKannonical(string number)
        {
            StringBuilder numberAsString = new StringBuilder();
            //for (int i = 0; i <= output.Length; i++)
            //{
            numberAsString.Clear();
            numberAsString = ConvertNumbers(number, numberAsString);
            //numberAsString = ConvertNumbers(number, numberAsString);
            //numberAsString = ConvertNumbers(number, numberAsString);

            //numberAsString.Clear();
            //foreach (char ch in number)
            //{
            //    if (char.IsDigit(ch) || (ch == '+'))
            //    {
            //        numberAsString.Append(ch);
            //    }
            //}

            //if (numberAsString.Length >= 2 && numberAsString[0] == '0' && numberAsString[1] == '0')
            //{
            //    numberAsString.Remove(0, 1);
            //    numberAsString[0] = '+';
            //}

            //while (numberAsString.Length > 0 && numberAsString[0] == '0')
            //{
            //    numberAsString.Remove(0, 1);
            //}

            //if (numberAsString.Length > 0 && numberAsString[0] != '+')
            //{
            //    numberAsString.Insert(0, code);
            //}
            //numberAsString.Clear();
            //foreach (char ch in number)
            //{
            //    if (char.IsDigit(ch) || (ch == '+'))
            //    {
            //        numberAsString.Append(ch);
            //    }
            //}
            //if (numberAsString.Length >= 2 && numberAsString[0] == '0' && numberAsString[1] == '0')
            //{
            //    numberAsString.Remove(0, 1);
            //    numberAsString[0] = '+';
            //}
            //while (numberAsString.Length > 0 && numberAsString[0] == '0')
            //{
            //    numberAsString.Remove(0, 1);
            //}
            //if (numberAsString.Length > 0 && numberAsString[0] != '+')
            //{
            //    numberAsString.Insert(0, code);
            //}
            //}
            return numberAsString.ToString();
        }

        private static StringBuilder ConvertNumbers(string number, StringBuilder numberAsString)
        {
            foreach (char symbol in number)
            {
                if (char.IsDigit(symbol) || (symbol == '+'))
                {
                    numberAsString.Append(symbol);
                }
            }

            if (numberAsString.Length >= 2 && numberAsString[0] == '0' && numberAsString[1] == '0')
            {
                numberAsString.Remove(0, 1);
                numberAsString[0] = '+';
            }
            while (numberAsString.Length > 0 && numberAsString[0] == '0')
            {
                numberAsString.Remove(0, 1);
            }

            if (numberAsString.Length > 0 && numberAsString[0] != '+')
            {
                numberAsString.Insert(0, CountryCode);
            }

            return numberAsString;
        }

        private static void Print(string text)
        {
            output.AppendLine(text);
        }
    }
}