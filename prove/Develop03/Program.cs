using System;
using System.Runtime.InteropServices;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        Phrase phrase = new Phrase();
        User user = new User();
        ProgramManager programManager = new ProgramManager();

        while (true)
        {
            // FOR every word in words
                // IF word contains "_"
                    // QUIT
                // ELSE
                    // 
            if (user.DoesUserQuit() || phrase.GetIsErased())
            {
                programManager.Quit();
            }
            else
            {
                WordExtractor wordExtractor = new WordExtractor();
                List<string> words = new List<string>();

                string currentPhrase = phrase.GetCurrentPhrase();

                words = wordExtractor.GetWordsInPhrase(currentPhrase);
                
                string newPhrase = wordExtractor.RemoveWords(words, 3);

                phrase.SetPhrase(newPhrase);
                phrase.DisplayPhrase();


                bool isEmpty = phrase.CheckIfEmpty(words, "_");

                if (isEmpty)
                {
                    programManager.Quit();
                }
            }
        }
    }
}