using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman2
{
    class Program
    {
        static string RandomWord()
        {
            Random r = new Random();

            List<string> words = new List<string>() { "cat", "dog", "eagle", "lion", "shark" };
            string word = words[r.Next(0, words.Count)];
            return word;
        }
      
        static string displayToPlayer(string wordToGuess)
        {

            string displayToPlayer = wordToGuess;
            for (int i = 0; i < wordToGuess.Length; i++)
                displayToPlayer += "_";
            return displayToPlayer;
        }

        static char Input()
        {
            char inputt = char.Parse(Console.ReadLine());
            return inputt;
        }

        static List<char> correctGuesses(char inputt, string wordToGuess ,int lettersReveald, string playersSees)
        {
            
            List<char> CorrectGuesses = new List<char>();
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == inputt)
                {
                   playersSees.ToCharArray()[i] = wordToGuess[i];
                    lettersReveald++;
                }
            }
           
            return CorrectGuesses;
        }
        static List<char> IncorrectGuesses(char inputt, string wordToGuess, int guesses)
        {
            List<char> incorrectGuesses = new List<char>();
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                
                if (wordToGuess[i] != inputt)
                {
                    incorrectGuesses.Add(inputt);
                    Console.WriteLine("Nope, there's no '{0}' in it!", inputt);
                    guesses--;
                }
            }
            return incorrectGuesses;
        }
        static bool GameIsRunning(int guesses, string wordToGuess, int lettersReveald)
        {
            if (guesses >=10)
            {
                
                return true;
            }
            else if (guesses == 0)
            {
                return false;
            }
             if (lettersReveald == wordToGuess.Length)
            {
                Console.WriteLine("You have won the game");
                return false;
            }
            else
            {
                return true;
            }
            
           
        }
        



        static void Main(string[] args)
        {
            
            string wordToGuess = RandomWord();
            string playersSees = displayToPlayer(wordToGuess);
            int lettersReveald = 0;
            int guesses = 10;

            while (GameIsRunning(guesses,wordToGuess,lettersReveald))
            {
                Console.WriteLine("Guess a letter: ");

                char inputt = Input();
                correctGuesses(inputt,wordToGuess,lettersReveald, playersSees);
                IncorrectGuesses(inputt, wordToGuess, guesses);

                
            }

        }
    }
}
