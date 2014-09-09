using System;
using System.Text;

class MovingLetters
{
    static void Main()
    {
        //read input
        string input = Console.ReadLine();
        string[] words = input.Split();
        //extracting letters
        StringBuilder sequence = new StringBuilder();
        int maxLength = MaximalLenght(words);
        // this is my first solution, have 80/100 because the time limit
        //for (int i = 0; i < maxLength; i++)
        //{
        //    for (int j = 0; j < words.Length; j++)
        //    {
        //        StringBuilder temp = new StringBuilder();
        //        temp.Append(words[j]);
        //        if (words[j].Length != 0)
        //        {
        //            sequence.Append(temp[temp.Length - 1]);
        //            temp.Remove(temp.Length - 1, 1);
        //            words[j] = temp.ToString();
        //        }
        //    }
        //}
        for (int index = 0; index < maxLength; index++)
        {
            for (int i = 0; i < words.Length; i++)
            {
                int currentLetterIndex = words[i].Length - 1 - index;
                if (currentLetterIndex >= 0)
                {
                    sequence.Append(words[i][currentLetterIndex]);
                }
            }
        }

        //moving letters        
        string firstSequence = sequence.ToString();
        int positionCount = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] >= 97 && sequence[i] <= 122)
            {
                positionCount = sequence[i] - 'a' + 1;
            }
            else if (sequence[i] >= 65 && sequence[i] <= 90)
            {
                positionCount = sequence[i] - 'A' + 1;
            }
            char tempLetter = sequence[i];
            int indexToMove = 0;
            if (positionCount > sequence.Length)
            {
                indexToMove = (positionCount - (sequence.Length)) + i;
            }
            else
            {
                indexToMove = positionCount + i;
            }
            for (int k = 0; k < 5; k++)
            {
                if (indexToMove >= sequence.Length)
                {
                    indexToMove -= sequence.Length;
                }
            }
            sequence.Remove(i, 1);
            sequence.Insert(indexToMove, tempLetter);
        }
        //print
        Console.WriteLine(sequence);
    }

    private static int MaximalLenght(string[] words)
    {
        int maxLength = 0;

        for (int i = 0; i < words.Length; i++)
        {
            int max = words[i].Length;
            if (max > maxLength)
            {
                maxLength = max;
            }
        }
        return maxLength;
    }
}

