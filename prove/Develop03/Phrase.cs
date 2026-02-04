using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace Develop03
{
    public class Phrase
    {
        private string currentPhrase;
        private List<string> phrases = new List<string>
        {
            "I want chicken, but I want it to be the really good chicken from minecraft",
            "they just want love in life, but struggle to find it. it's okay tho",
        };


        public Phrase()
        {
            currentPhrase = SelectRandomPhrase();
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
            Console.WriteLine(currentPhrase);
        }

        public string GetCurrentPhrase()
        {
            return currentPhrase;
        }

        public bool GetIsErased()
        {
            return isPhraseErased;
        }

        public void SetPhrase(string newPhrase)
        {
            currentPhrase = newPhrase;
        }
    }
}