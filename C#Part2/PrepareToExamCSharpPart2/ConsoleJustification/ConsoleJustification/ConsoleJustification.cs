using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ConsoleJustification
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            List<string> wordsList = new List<string>();
            string[] words;            
            for (int row = 0; row < rows; row++)
            {                
                words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    wordsList.Add(words[i]);
                }    
                

               


                
            }

        }
    }

