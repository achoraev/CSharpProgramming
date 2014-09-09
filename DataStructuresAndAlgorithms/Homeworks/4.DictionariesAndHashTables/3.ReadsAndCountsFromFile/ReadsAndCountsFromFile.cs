// 3.Write a program that counts how many times each word from given text file words.txt appears in it. The character casing differences should be ignored.
// The result words should be ordered by their number of occurrences in the text. Example:
//  is - 2
//  the - 2
//  this - 3
//  text - 6
namespace ReadsAndCountsFromFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ReadsAndCountsFromFile
    {
        public static void Main()
        {
            var input = new StreamReader("../../words.txt");
            using (input)
            {
                var words = new List<string>();
                var separators = new[] { "-", ".", ",", "!", "?", " "};
                IDictionary<string, int> wordsCount = new Dictionary<string, int>();

                string fileLine;
                while ((fileLine = input.ReadLine()) != null)
                {
                    var splitted = fileLine.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(w => w.ToLower());
                    words.AddRange(splitted);
                }

                CountWords(words, wordsCount);
            }
        }

        private static void CountWords(List<string> words, IDictionary<string, int> wordsCount)
        {
            foreach (string word in words)
            {
                int count = 1;
                if (wordsCount.ContainsKey(word))
                {
                    count = wordsCount[word] + 1;
                }
                wordsCount[word] = count;
            }

            var sorted = wordsCount.OrderBy(v => v.Value);
            foreach (var pair in sorted)
            {
                Console.WriteLine("{0} --> {1}", pair.Key, pair.Value);
            }
        }
    }
}