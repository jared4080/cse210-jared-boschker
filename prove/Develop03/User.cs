using System;


namespace Develop03
{
    public class User
    {
        public bool DoesUserQuit()
        {
            Console.Write("(enter) continue\n(q) quit\ndo something: ");
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

        public int GetUserNumber()
        {
            int defaultAmount = 3;

            Console.Write("(enter) remove 3 words\n(enter number) remove number of words\ndo something: ");
            string userInput = Console.ReadLine();

            while (true)
            {
                int number;
                bool isNumber = int.TryParse(userInput, out number);

                if (isNumber)
                {
                    return number;
                }
                else
                {
                    return defaultAmount;
                }
            }
        }
    }
}