using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


namespace Develop03
{
    public class WordExtractor
    {
        List<string> wordsToExtract = new List<string>();
        List<string> extractedWords = new List<string>();


        void HideRandomWords()
        {
            Phrase phrase = new Phrase();
            string currentPhrase = phrase.GetCurrentPhrase();
        }

        public List<string> ExtractWords(string phrase)
        {
            List<string> wordsInPhrase = new List<string>();
            wordsInPhrase = phrase.Split(' ').ToList();

            foreach (string word in wordsInPhrase)
            {
                if (!word.Contains('_'))
                {
                    wordsInPhrase.Add(word);
                }
            }

            return wordsInPhrase;
        }

        // FIX THIS METHOD
        void RemoveWordsInPhrase(List<string> wordsInPhrase)
        {
            Random random = new Random();

            List<string> words = wordsInPhrase;

            for (int i = 0; i < 3; i++)
            {                
                int randomIndex = random.Next(wordsInPhrase.Count);
                string chosenWord = wordsInPhrase[randomIndex];

                for (int wordIndex = 0; wordIndex < wordsInPhrase.Count; wordIndex++)
                {
                    if (wordsInPhrase[wordIndex] == chosenWord)
                    {
                        words[wordIndex] = new string('_', chosenWord.Length);
                        break;
                    }
                }
            }
        }
    }
}