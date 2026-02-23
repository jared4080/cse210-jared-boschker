using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace Develop03
{
    public class Phrase
    {
        string _currentPhrase;
        string _location;
        string _subject;

        Dictionary<string, string> _phrasesDict = new Dictionary<string, string>
        {
            {"lava chicken by jack black", "La-la-la-lava, ch-ch-ch-chicken Steve's Lava Chicken, yeah, it's tasty as hell Ooh, mamacita, now you're ringin' the bell Crispy and juicy, now you're havin' a snack Ooh, super spicy, it's a lava attack"},
            
            {"minecraft", "I want chicken, but I want it to be the really good chicken from minecraft"},
            
            {"something about love", "they just want love in life, but struggle to find it. it's okay tho"},
            
            {"john 6:35", "And Jesus said unto them, I am the bread of like: he that cometh to me shall never hunger; and he that believeth on me shall never thirst."}
        };


        public Phrase()
        {
            _currentPhrase = SelectRandomPhrase();
        }

        public string SelectRandomPhrase()
        {
            Random random = new Random();

            string randomSubject = _phrasesDict.Keys.ElementAt(random.Next(_phrasesDict.Count));
            SetSubject(randomSubject);

            return _phrasesDict[randomSubject];
        }

        public string GetCurrentSubject()
        {
            return _subject;
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
            Console.WriteLine($"{_subject} - {_currentPhrase}");
        }

        public string GetCurrentPhrase()
        {
            return _currentPhrase;
        }
        
        public void SetPhrase(string newPhrase)
        {
            _currentPhrase = newPhrase;
        }

        void SetSubject(string subject)
        {
            _subject = subject;
        }
    }
}