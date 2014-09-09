using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class PHPVariables
{
    static void Main()
    {
        StringBuilder var = new StringBuilder();      
        bool isVariable = false;
        bool multiLine = false;
        HashSet <string> set = new HashSet <string>();
        for (int row = 1; row < 50; row++)
        {
            string input = Console.ReadLine().Trim();
            if (input == "?>")
            {
                break;
            }   
            for (int j = 0; j < input.Length; j++)
            {
                if (input == "<?php")
                {
                    break;
                }                
                if (j < input.Length-1)
                {
                    if (input[j] == '/' && input[j + 1] == '*')
                    {
                        if (j == 0)
                        {
                            multiLine = true;                            
                        }
                    }
                    if (input[j] == '*' && input[j + 1] == '/')
                    {
                        multiLine = false;
                        break;
                    }
                    if (input[j] == '/' && input[j + 1] == '/')
                    {
                        if (j==0)
                        {
                            break; 
                        }
                        else if (j -1 != '"')
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    } 
                }
                //if (multiLine)
                //{
                //    break;
                //}
                if (input[j] == '#')
                {
                    break;
                }
                else if (input[j] == '\\')
                {
                    j++;
                    break;
                }
                if (input[j] == '$')
                {
                    if (j > 0 && (j-1) != '\\'&& (j-2) != '\\')
                    {
                        isVariable = true; 
                    }
                    else
                    {
                        isVariable = true;
                    }
                }
                else if (!Char.IsLetter(input[j]) && !Char.IsNumber(input[j]) && !(input[j] == '_'))
                //(input[j] == ' ' || input[j] == ';' || input[j] == '[' || input[j] == '=' || input[j] == '.' || input[j] == ',' || input[j] == '"' || input[j] == ']' || input[j] == '}')
                {
                    isVariable = false;
                    if (var.Length > 0 && !multiLine)
                    {
                        set.Add(var.ToString()); 
                    }
                    var.Clear();
                }
                else if(isVariable && !multiLine)
                {
                    var.Append(input[j]);
                }                
            }
        }
        Console.WriteLine(set.Count);
        string [] ar = set.ToArray();
        Array.Sort(ar);
        foreach (var item in ar)
        {
            Console.WriteLine(item);
        }
    }
}