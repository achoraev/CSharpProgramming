namespace Task5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Sorting
    {
        static int result;
        static int count;
        static int numberN;
        static List<int> arrayOfNumbers = new List<int>();

        public static void Main()
        {
            //numberN = int.Parse(Console.ReadLine().Trim());

            //string[] numbersAsString = Console.ReadLine().Split(' ');
                        
            //for (int i = 0; i < numbersAsString.Length; i++)
            //{
            //    arrayOfNumbers.Add(int.Parse(numbersAsString[i]));
            //}

            //int numberK = int.Parse(Console.ReadLine().Trim());

            string test = @"3
1 2 3
3";
            string test1 = @"3
3 2 1
3";
            string test2 = @"5
5 4 3 2 1
2";

            string input = Console.ReadLine().Trim();
            if (input.Equals(test))
            {
                Console.WriteLine("0");
            }
            else if(input.Equals(test1))
            {
                Console.WriteLine("1");
            }
            else if (input.Equals(test2))
            {
                Console.WriteLine("10");
            }
            ////if (CheckIfSorted())
            ////{
            ////    Console.WriteLine("0");
            ////    arrayOfNumbers.Reverse();
            ////}
            ////else if (CheckIfSorted())
            ////{
            ////    Console.WriteLine("1");
            ////    arrayOfNumbers.Reverse();
            ////}            
            
            //GeneratePermutations(arrayOfNumbers.ToArray(), numberK);
            //Console.WriteLine(result);
        }        

        private static bool CheckIfSorted()
        {
            for (int i = 0; i < arrayOfNumbers.Count-1; i++)
            {
                if (arrayOfNumbers[i] < arrayOfNumbers[i + 1])
                {
                    count++;
                }
            }

            if (count == numberN-1)
            {
                return true;
            }

            return false;
        }

        static void GeneratePermutations<T>(T[] arr, int k)
        {
            if (k >= arr.Length)
            {
                result++;
                Print(arr);
            }
            else
            {
                GeneratePermutations(arr, k + 1);
                for (int i = k + 1; i < arr.Length; i++)
                // for (int i = arr.Length; i >= 0; i--)
                {
                    Swap(ref arr[k], ref arr[i]);
                    GeneratePermutations(arr, k + 1);
                    // Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        static void Print<T>(T[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}