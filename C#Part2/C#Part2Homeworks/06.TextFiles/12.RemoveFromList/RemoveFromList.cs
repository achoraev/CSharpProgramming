using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;
// Write a program that removes from a text file all words listed 
// in given another text file. Handle all possible exceptions in your methods.

class RemoveByList
{
    static void Main()
    {
        try
        {
            string regex = @"\b(" + String.Join("|", File.ReadAllLines("../../list.txt")) + @")\b";
            string fileContent = File.ReadAllText("../../FileToRemove.txt");
            File.WriteAllText("../../result.txt", Regex.Replace(fileContent, regex, String.Empty, RegexOptions.IgnoreCase));
            Console.WriteLine("Replace Complete!");
            Console.WriteLine("Check folder for result.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File Not Found!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory Not Found!");
        }
        catch (IOException)
        {
            Console.WriteLine("Input/Output Error!");
        }
        catch (SecurityException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("File Access Error!");
        }
        catch (Exception)
        {
            Console.WriteLine("There is some problem with file.");
        }
    }
}

