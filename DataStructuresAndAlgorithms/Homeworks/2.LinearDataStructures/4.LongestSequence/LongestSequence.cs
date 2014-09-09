// 4.Write a method that finds the longest subsequence of equal numbers in given List<int> and returns the result as new List<int>. 
// Write a program to test whether the method works correctly.
namespace LongestSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LongestSequence
    {
        public static void Main()
        {
            List<int> inputList = new List<int>() { 1, 2, 3, 4, 4, 4, 4, 4, 5, 6, 1, 2, 1, 1, 1 };

            List<int> answer = FindLongestSequence(inputList);

            Console.WriteLine(string.Join(", ", answer));
        }

        private static List<int> FindLongestSequence(List<int> inputList)
        {
            List<int> answer = new List<int>();
            int indexOfStartOfSeq = 0;
            int countElements = 0;

            for (int i = 0; i < inputList.Count - 1; i++)
            {
                int currEqualElementsCount = 1;
                while (i < inputList.Count - 1 && inputList[i] == inputList[i + 1])
                {
                    i++;
                    currEqualElementsCount++;
                }
                if (currEqualElementsCount > countElements)
                {
                    countElements = currEqualElementsCount;
                    indexOfStartOfSeq = i - countElements + 1;
                }
            }

            for (int i = indexOfStartOfSeq; i < indexOfStartOfSeq + countElements; i++)
            {
                answer.Add(inputList[i]);
            }

            return answer;
        }
    }
}