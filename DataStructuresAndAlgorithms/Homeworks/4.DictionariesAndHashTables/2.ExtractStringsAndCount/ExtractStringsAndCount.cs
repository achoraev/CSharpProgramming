// 2.Write a program that extracts from a given sequence of strings all elements that present in it odd number of times. Example:
// {C#, SQL, PHP, PHP, SQL, SQL } - {C#, SQL}
namespace ExtractStringsAndCount
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ExtractStringsAndCount
    {
        public static void Main()
        {
            string text = "C#, SQL, PHP, PHP, SQL, SQL";
            IDictionary<string, int> wordsCount = new Dictionary<string, int>();
            CountWords(text, wordsCount);
        }

        private static void CountWords(string text, IDictionary<string, int> wordsCount)
        {
            string[] words = text.Split(new char[] { ' ', ',', '.' },
                StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                int count = 1;
                if (wordsCount.ContainsKey(word))
                {
                    count = wordsCount[word] + 1;
                }
                wordsCount[word] = count;
            }

            foreach (var pair in wordsCount)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.WriteLine("{0} --> {1}", pair.Key, pair.Value);
                }                
            }
        }
    }
}