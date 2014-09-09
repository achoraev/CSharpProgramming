using System;
using System.Numerics;

class CardWars
{
    static void Main()
    {
        int numberGames = int.Parse(Console.ReadLine());

        int firstPlayerScore = 0;
        int secondPlayerScore = 0;
        BigInteger totalScoreFirst = 0;
        BigInteger totalScoreSecond = 0;

        int firstPlayerGamesWon = 0;
        int secondPlayerGamesWon = 0;
        bool XCard = false;
        bool XCardSecond = false;

        for (int i = 0; i < numberGames; i++)
        {
            string firstCardPlayerOne = Console.ReadLine();
            string secondCardPlayerOne = Console.ReadLine();
            string thirdCardPlayerOne = Console.ReadLine();

            string firstCardPlayerTwo = Console.ReadLine();
            string secondCardPlayerTwo = Console.ReadLine();
            string thirdCardPlayerTwo = Console.ReadLine();
            // first player hand           
            FirstPlayerScore(ref firstPlayerScore, ref XCard, firstCardPlayerOne);
            if (firstCardPlayerOne == "Y")
            {
                totalScoreFirst -= 200;
            }
            FirstPlayerScore(ref firstPlayerScore, ref XCard, secondCardPlayerOne);
            if (secondCardPlayerOne == "Y")
            {
                totalScoreFirst -= 200;
            }
            FirstPlayerScore(ref firstPlayerScore, ref XCard, thirdCardPlayerOne);
            if (thirdCardPlayerOne == "Y")
            {
                totalScoreFirst -= 200;
            }
            //thirdCardPlayerTwo
            SecondPlayerScore(ref secondPlayerScore, ref XCardSecond, firstCardPlayerTwo);
            if (firstCardPlayerTwo == "Y")
            {
                totalScoreSecond -= 200;
            }
            SecondPlayerScore(ref secondPlayerScore, ref XCardSecond, secondCardPlayerTwo);
            if (secondCardPlayerTwo == "Y")
            {
                totalScoreSecond -= 200;
            }
            SecondPlayerScore(ref secondPlayerScore, ref XCardSecond, thirdCardPlayerTwo);
            if (thirdCardPlayerTwo == "Y")
            {
                totalScoreSecond -= 200;
            }

            if (XCard && XCardSecond)
            {
                totalScoreFirst += 50;
                totalScoreSecond += 50;
            }
            if (firstPlayerScore > secondPlayerScore)
            {
                firstPlayerGamesWon++;
                totalScoreFirst += firstPlayerScore;
            }
            else if (secondPlayerScore > firstPlayerScore)
            {
                secondPlayerGamesWon++;
                totalScoreSecond += secondPlayerScore;
            }
            if (firstPlayerScore < 0)
            {
                totalScoreFirst = firstPlayerScore;
            }
            else if (secondPlayerScore < 0)
            {
                totalScoreSecond = secondPlayerScore;
            }
            else
            {
                firstPlayerScore = 0;
                secondPlayerScore = 0;
            }
            
        }


        if (XCard && XCardSecond)
        {
               
        }
        else if (XCard)
        {
            Console.WriteLine("X card drawn! Player one wins the match!");
            goto Finish;
        }

        else if (XCardSecond)
        {
            Console.WriteLine("X card drawn! Player two wins the match!");
            goto Finish;
        }
        
        if (totalScoreFirst > totalScoreSecond)
        {
            Console.WriteLine("First player wins!");            
            Console.WriteLine("Score: {0}", totalScoreFirst);           
            Console.WriteLine("Games won: {0}", firstPlayerGamesWon);
        }
        else if (totalScoreSecond > totalScoreFirst)
        {
            Console.WriteLine("Second player wins!");           
            Console.WriteLine("Score: {0}", totalScoreSecond);            
            Console.WriteLine("Games won: {0}", secondPlayerGamesWon);
        }
        else if (totalScoreSecond == totalScoreFirst)
        {
            Console.WriteLine("It's a tie!");            
            Console.WriteLine("Score: {0}", (totalScoreFirst));
        }
        Finish:
        Console.WriteLine();
    }

    private static void SecondPlayerScore(ref int secondPlayerScore, ref bool XCardSecond, string thirdCardPlayerTwo)
    {
        switch (thirdCardPlayerTwo)
        {
            case "2": secondPlayerScore += 10; break;
            case "3": secondPlayerScore += 9; break;
            case "4": secondPlayerScore += 8; break;
            case "5": secondPlayerScore += 7; break;
            case "6": secondPlayerScore += 6; break;
            case "7": secondPlayerScore += 5; break;
            case "8": secondPlayerScore += 4; break;
            case "9": secondPlayerScore += 3; break;
            case "10": secondPlayerScore += 2; break;
            case "A": secondPlayerScore += 1; break;
            case "J": secondPlayerScore += 11; break;
            case "Q": secondPlayerScore += 12; break;
            case "K": secondPlayerScore += 13; break;
            case "Z": secondPlayerScore *= 2; break;
            //case "Y": secondPlayerScore -= 200; break;
            case "X": XCardSecond = true; break;
        }
    }

    private static void FirstPlayerScore(ref int firstPlayerScore, ref bool XCard, string firstCardPlayerOne)
    {
        switch (firstCardPlayerOne)
        {
            case "2": firstPlayerScore += 10; break;
            case "3": firstPlayerScore += 9; break;
            case "4": firstPlayerScore += 8; break;
            case "5": firstPlayerScore += 7; break;
            case "6": firstPlayerScore += 6; break;
            case "7": firstPlayerScore += 5; break;
            case "8": firstPlayerScore += 4; break;
            case "9": firstPlayerScore += 3; break;
            case "10": firstPlayerScore += 2; break;
            case "A": firstPlayerScore += 1; break;
            case "J": firstPlayerScore += 11; break;
            case "Q": firstPlayerScore += 12; break;
            case "K": firstPlayerScore += 13; break;
            case "Z": firstPlayerScore *= 2; break;
            //case "Y": firstPlayerScore -= 200; break;
            case "X": XCard = true; break;
        }
    }
}