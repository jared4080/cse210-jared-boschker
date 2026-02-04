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
        
        programManager.ClearConsole();

        while (true)
        {
            if (user.DoesUserQuit() || phrase.CheckIfEmpty(words, "_"))
            {
                programManager.Quit();
            }
            else
            {
                int wordRemoveAmount = user.GetUserNumber();

                currentPhrase = phrase.GetCurrentPhrase();
                words = wordManager.GetWordsInPhrase(currentPhrase);
                
                string newPhrase = wordManager.RemoveWords(words, wordRemoveAmount);

                programManager.ClearConsole();

                phrase.SetPhrase(newPhrase);
                phrase.DisplayPhrase();
            }
        }
    }
}