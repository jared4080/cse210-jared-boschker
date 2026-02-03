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
                Console.WriteLine("continue");
            }
        }
    }
}