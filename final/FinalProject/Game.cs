using System;


namespace FinalProject
{    
    public abstract class Game
    {
        int currencyToStart = 0;
        int minBetAmount = 0;
        int playerBetAmount = 0;


        public Game(Player player)
        {
            PlaceBet(player.GetMoneyAmount());
        }


        public int GetCurrencyToStart()
        {
            return currencyToStart;
        }

        public void PlaceBet(int playerCurrency)
        {
            Console.WriteLine($"you gotta have at least {minBetAmount} to gamble on this one");
            Console.Write("\nhow much u betting? ");
            
            try
            {
                playerBetAmount = Int32.Parse(Console.ReadLine());

                if (playerBetAmount < minBetAmount || playerCurrency < playerBetAmount)
                {
                    Console.WriteLine("\nnot enough money bub");
                    ExitGame();
                }
                else
                {
                    Console.WriteLine("alright");
                    Start();
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