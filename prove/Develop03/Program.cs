using System;
using System.Runtime.InteropServices;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        Phrase phrase = new Phrase();
        User user = new User();

        while (true)
        {            
            if (user.DoesUserQuit() || phrase.GetIsErased())
            {
                ProgramManager programManager = new ProgramManager();
                programManager.Quit();
            }
            else
            {
                // IF phrase is full of underscores
                    // QUIT
                //ELSE
                    // REPLACE words that haven't been replaced with underscores
                
                WordExtractor wordExtractor = new WordExtractor();
                List<string> words = new List<string>();
                words = wordExtractor.GetWordsInPhrase("asdfjio asdf money money hahah, asdf s fdsd f mama");

                
                string newPhrase = wordExtractor.RemoveWords(words, 3);
                Console.WriteLine(newPhrase);
                
                
                // phrase.DisplayPhrase();
            }
        }
    }
}