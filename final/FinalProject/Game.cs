using System;


namespace FinalProject
{    
    public abstract class Game
    {
        int currencyToStart = 0;
        int minBetAmount = 0;
        int playerBetAmount = 0;
        int numberOfGamblers = 2;

        string startMessage = "hi";

        double chancesOfWinning = 0.5;


        public int GetCurrencyToStart()
        {
            return currencyToStart;
        }

        public void PlaceBet()
        {
            Console.WriteLine($"you gotta have at least {minBetAmount} to gamble on this one");
            Console.WriteLine("\nhow much u betting? ");
            
            try
            {
                playerBetAmount = Int32.Parse(Console.ReadLine());

                if (playerBetAmount < minBetAmount)
                {
                    Console.WriteLine("not enough money bub");
                    ExitGame();
                }
            }
            catch
            {
                Console.WriteLine("bruh, we only accept real moneies like 3 monies or something");
            }
        }

        public void ExitGame()
        {
            Console.WriteLine("ok, we done gambling on this one");
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public abstract void Start();
    }
}