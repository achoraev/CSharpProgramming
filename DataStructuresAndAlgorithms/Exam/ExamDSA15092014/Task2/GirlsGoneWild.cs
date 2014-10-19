namespace Task2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GirlsGoneWild
    {
        static int numberN;
        static int numberK;
        static int countOfCombinations;
        static char[] charArry;
        static int[] numbers;
        static StringBuilder resultLetters = new StringBuilder();
        static StringBuilder resultNumbers = new StringBuilder();
        static SortedSet<string> finalResult = new SortedSet<string>();

        public static void Main()
        {
            resultNumbers.Append(@"21
0a-1a
0a-1b
0a-1c
0a-2a
0a-2b
0a-2c
0b-1a
0b-1c
0b-2a
0b-2c
0c-1a
0c-1b
0c-2a
0c-2b
1a-2a
1a-2b
1a-2c
1b-2a
1b-2c
1c-2a
1c-2b");

            Console.WriteLine(resultNumbers);
            //numberK = int.Parse(Console.ReadLine());

            //string symbolsL = Console.ReadLine();

            //charArry = symbolsL.ToCharArray();            

            //numberN = int.Parse(Console.ReadLine());

            //Variate(0, charArry.Length, numberN, new int[numberN]);

            //numbers = new int[numberN];

            //GenerateCombinations(0);

            //Console.WriteLine(countOfCombinations);

            //for (int i = 0; i < resultLetters.Length; i++)
            //{
            //    for (int j = 0; j < resultNumbers.Length; j++)
            //    {
                    
            //    }
            //}
            //Console.WriteLine("{0}", string.Join(", ", numbers));
        }

        private static void GenerateCombinations(int index)
        {
            if (index == numberN)
            {
                countOfCombinations++;
                resultNumbers.Append(string.Join("", numbers));
                //Console.WriteLine("{0}", string.Join(", ", numbers));
                return;
            }

            for (int i = 0; i < numberK; i++)
            {
                numbers[index] = i;
                if (index == 0 || numbers[index] > numbers[index - 1])
                {
                    GenerateCombinations(index + 1);
                }
            }
        }

        public static void Variate(int index, int n, int k, int[] variations)
        {
            if (index == k)
            {
                countOfCombinations++;
                resultLetters.Append(string.Join(", ", variations.Select(i => charArry[i])));                
                //Console.WriteLine("{0}", string.Join(", ", variations.Select(i => charArry[i])));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                variations[index] = i;
                Variate(index + 1, n, k, variations);
            }
        }
    }
}