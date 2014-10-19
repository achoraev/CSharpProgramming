namespace MessageInBottle
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MessageInBottle
    {
        static int count = 0;
        static string sequence;
        static SortedDictionary<char, string> code = new SortedDictionary<char, string>();
        static SortedDictionary<string, int> output = new SortedDictionary<string, int>();
        static StringBuilder nums = new StringBuilder();
        static StringBuilder result = new StringBuilder();
        public static void Main()
        {
            // read input
            sequence = Console.ReadLine().Trim();
            string cypher = Console.ReadLine().Trim();
            char key = char.MinValue;
            nums.Append(string.Empty);

            for (int i = 0; i < cypher.Length; i++)
            {
                if (cypher[i] >= 'A' && cypher[i] <= 'Z')
                {
                    if (key != char.MinValue)
                    {
                        if (!code.ContainsKey(key))
                        {
                            code.Add(key, nums.ToString());
                            nums.Clear();
                        }
                        else
                        {
                            code[key] = nums.ToString();
                        }
                    }

                    key = cypher[i];
                }
                else
                {
                    nums.Append(cypher[i]);
                }
            }

            if (key != char.MinValue)
            {
                code.Add(key, nums.ToString());
                nums.Clear();
            }

            // solution             
            EncodedMessage(0);

            // print result
            Console.WriteLine(count);
            foreach (var item in output)
            {
                Console.WriteLine(item.Key);
            }
        }

        private static void EncodedMessage(int index)
        {
            if (index == sequence.Length)
            {
                count++;
                output.Add(result.ToString(), 1);
                return;
            }

            foreach (var key in code)
            {
                if (sequence.Substring(index).StartsWith(key.Value))
                {
                    result.Append(key.Key);
                    EncodedMessage(index + key.Value.Length);
                    result.Length--;
                }
            }
        }
    }
}