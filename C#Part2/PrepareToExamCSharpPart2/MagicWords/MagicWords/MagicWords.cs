using System;
using System.Collections.Generic;
using System.Text;

class MagicWords
{
    static void Main()
    {
        //read input
        int rows = int.Parse(Console.ReadLine().TrimEnd());
        List<string> words = new List<string>();

        for (int i = 0; i < rows; i++)
        {
            words.Add(Console.ReadLine());
        }

        // solution
        int newPosition = 0;
        for (int n = 0; n < words.Count; n++)
        {
            newPosition = words[n].Length % (rows+1);
            if (newPosition <= words.Count && newPosition >= 0)
            {
                string moveWord = words[n];
                words[n] = null;
                words.Insert(newPosition, moveWord);
                words.Remove(null);
            }
        }

        // print
        string temp = string.Empty;
        StringBuilder output = new StringBuilder();
        int position = 0;        
        for (int k = 0; k < 1000; k++)
        {
            for (int i = 0; i < rows; i++)
            {
                temp = words[i];
                for (int j = position; j < position + 1; j++)
                {
                    if (j < temp.Length)
                    {
                        output.Append(temp[j]);
                    }
                }
                temp = string.Empty;
            }
            position++;
        }
        Console.WriteLine(output.ToString());
    }    
}

