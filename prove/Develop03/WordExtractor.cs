using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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

        public List<string> GetWordsInPhrase(string phrase)
        {
            List<string> wordsInPhrase = new List<string>();
            wordsInPhrase = phrase.Split(' ').ToList();

            return wordsInPhrase;
        }

        public string RemoveWords(List<string> words, int amountToRemove)
        {
            List<string> newWordsList = new List<string>(words);
            Random random = new Random();
            
            List<int> validIndices = Enumerable.Range(0, newWordsList.Count).Where(i => !newWordsList[i].Contains('_')).ToList();

            for (int i = 0; i < amountToRemove && validIndices.Count > 0; i++)
            {
                int randIndex = random.Next(validIndices.Count);
                int index = validIndices[randIndex];

                newWordsList[index] = new string('_', newWordsList[index].Length);
                validIndices.RemoveAt(randIndex);
            }

            return string.Join(" ", newWordsList);
        }
    }
}