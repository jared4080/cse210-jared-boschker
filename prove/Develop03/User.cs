using System;


namespace Develop03
{
    public class User
    {
        public bool DoesUserQuit()
        {
            Console.Write("""press enter to continue, or "q" to quit: """);
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "q")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}