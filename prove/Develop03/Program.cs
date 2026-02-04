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
        WordExtractor wordExtractor = new WordExtractor();
        
        List<string> words = new List<string>();

        string currentPhrase = phrase.GetCurrentPhrase();
        words = wordExtractor.GetWordsInPhrase(currentPhrase);

        while (true)
        {
            if (user.DoesUserQuit() || phrase.CheckIfEmpty(words, "_"))
            {
                programManager.Quit();
            }
            else
            {
                currentPhrase = phrase.GetCurrentPhrase();
                words = wordExtractor.GetWordsInPhrase(currentPhrase);
                
                string newPhrase = wordExtractor.RemoveWords(words, 3);

                phrase.SetPhrase(newPhrase);
                phrase.DisplayPhrase();
            }
        }
    }
}