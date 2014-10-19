namespace Frames
{
    using System;    
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Frames
    {
        static int N;
        static int frame1;
        static int frame2;
        static int numbersToCombine;
        static string[] frames;
        static int[] result;
        static List<string> output = new List<string>();

        static void Main()
        {            
            N = int.Parse(Console.ReadLine());
            frames = new string[N];
            result = new int[2];
            output.Add("12");

            for (int i = 0; i < N; i++)
            {
                frames = Console.ReadLine().Trim().Split(' ');
                frame1 = int.Parse(frames[0]);
                frame2 = int.Parse(frames[1]);
                if (frame1 > frame2)
                {
                    numbersToCombine = frame1 - frame2;
                }
                else if (frame1 == frame2)
                {
                    numbersToCombine = 1;
                }
                else
                {
                    numbersToCombine = (frame1 - frame2) * -1;
                }

                
                GenerateCombinations(0);
            }

            PrintResult();
        }

        private static void PrintResult()
        {
            int count = output.Count;

            while (count > 0)
            {
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine(output[i]);
                }
                count--;
            }
        }

        private static void GenerateCombinations(int index)
        {
            if (index == numbersToCombine)
            {
                GenerateResult();
                return;
            }

            for (int i = frame1; i <= (frame1+numbersToCombine); i++)
            {
                result[index] = i;                
                GenerateCombinations(index + 1);                
            }
        }

        private static void GenerateResult()
        {            
            output.Add("(" + string.Join(", ", result) + ")");            
        }
    }
}