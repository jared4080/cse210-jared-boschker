using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace Develop03
{
    public class Phrase
    {
        string currentPhrase;
        string location;
        List<string> phrases = new List<string>
        {
            "I want chicken, but I want it to be the really good chicken from minecraft",
            "they just want love in life, but struggle to find it. it's okay tho",
        };

        public Phrase()
        {
            location = "";
        }

        public Phrase(string book, string verse, string chapter)
        {
            currentPhrase = SelectRandomPhrase();
            location = $"{book} {chapter}:{verse}";
        }

        public Phrase(string book, string startVerse, string endVerse, string chapter)
        {
            currentPhrase = SelectRandomPhrase();
            location = $"{book} {chapter}:{startVerse}-{endVerse}";
        }

        public string SelectRandomPhrase()
        {
            Random random = new Random();
            string randomPhrase = phrases[random.Next(phrases.Count)];
            
            return randomPhrase;
        }

        public bool CheckIfEmpty(List<string> phraseList, string characterToFind)
        {
            foreach (string word in phraseList)
            {
                if (!word.Contains(characterToFind))
                {
                    return false;
                }
            }
            return true;
        }

        public void DisplayPhrase()
        {
            Console.WriteLine($"{location} {currentPhrase}");
        }

        public string GetCurrentPhrase()
        {
            return currentPhrase;
        }
        
        public void SetPhrase(string newPhrase)
        {
            currentPhrase = newPhrase;
        }
    }
}