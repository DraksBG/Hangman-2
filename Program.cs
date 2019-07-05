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
        static string WordToGuessUpper(string wordToGuess)
        {
            string wordToUpper = wordToGuess.ToUpper();
            return wordToUpper;
        }
        static StringBuilder displayToPlayer(string wordToGuess)
        {

            StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++)
                displayToPlayer.Append('_');
            return displayToPlayer;
        }
        static 
        static List<char> correctGuesses()
        {

        }



        static void Main(string[] args)
        {
            string wordToGuess = RandomWord();
        }
    }
}
