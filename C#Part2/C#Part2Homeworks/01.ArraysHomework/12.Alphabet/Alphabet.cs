using System;
//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.

class Alphabet
{
    static void Main()
    {
        char[] array = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        Console.WriteLine("Enter Word: ");
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            char temp = word[i];
            for (int j = 0; j < array.Length; j++)
            {
                if (temp == array[j])
                {
                    Console.Write("Letter {0} is in index {1} in the array.", temp, j);
                }                
            }
            Console.WriteLine();
        }        
    }
}