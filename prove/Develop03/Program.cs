using System;
using System.Runtime.InteropServices;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        ProgramManager programManager = new ProgramManager();
        WordManager wordManager = new WordManager();
        Phrase phrase = new Phrase();
        User user = new User();

        List<string> words = new List<string>();

        string currentPhrase = phrase.GetCurrentPhrase();
        words = wordManager.GetWordsInPhrase(currentPhrase);

        while (true)
        {
            if (user.DoesUserQuit() || phrase.CheckIfEmpty(words, "_"))
            {
                programManager.Quit();
            }
            else
            {
                currentPhrase = phrase.GetCurrentPhrase();
                words = wordManager.GetWordsInPhrase(currentPhrase);
                
                string newPhrase = wordManager.RemoveWords(words, 3);

                phrase.SetPhrase(newPhrase);
                phrase.DisplayPhrase();
            }
        }
    }
}