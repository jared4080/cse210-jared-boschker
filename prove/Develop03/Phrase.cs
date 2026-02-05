using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace Develop03
{
    public class Phrase
    {
        string _currentPhrase;
        string _location;
        List<string> _phrases = new List<string>
        {
            "For God so loved the world that he gave* his only Son, so that everyone who believes in him might not perish but might have eternal life",
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to Him, and He will make your paths straight.",
            "I want chicken, but I want it to be the really good chicken from minecraft",
            "they just want love in life, but struggle to find it. it's okay tho",
        };

        public Phrase()
        {
            _currentPhrase = SelectRandomPhrase();
            _location = "";
        }

        public Phrase(string book, string verse, string chapter)
        {
            _currentPhrase = SelectRandomPhrase();
            _location = $"{book} {chapter}:{verse}";
        }

        public Phrase(string book, string startVerse, string endVerse, string chapter)
        {
            _currentPhrase = SelectRandomPhrase();
            _location = $"{book} {chapter}:{startVerse}-{endVerse}";
        }

        public string SelectRandomPhrase()
        {
            Random random = new Random();
            string randomPhrase = _phrases[random.Next(_phrases.Count)];
            
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
            Console.WriteLine($"{_location} {_currentPhrase}");
        }

        public string GetCurrentPhrase()
        {
            return _currentPhrase;
        }
        
        public void SetPhrase(string newPhrase)
        {
            _currentPhrase = newPhrase;
        }
    }
}