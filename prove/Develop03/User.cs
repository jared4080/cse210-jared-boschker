using System;


namespace Develop03
{
    public class User
    {
        public bool DoesUserQuit()
        {
            Console.WriteLine("""press enter to continue, or "q" to quit""");
            string userInput = Console.ReadLine();

            if (userInput == "q")
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