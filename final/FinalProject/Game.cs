using System;


namespace FinalProject
{    
    public abstract class Game
    {
        int currencyToStart = 0;
        int minBetAmount = 0;
        int playerBetAmount = 0;

        int npcBetAmount = 0;

        Player _player;


        public Game(Player player)
        {
            _player = player;

            PlaceBet(_player.GetMoneyAmount());
        }


        public int GetCurrencyToStart()
        {
            return currencyToStart;
        }

        public void PlaceBet(int playerCurrency)
        {
            Console.WriteLine($"you gotta have at least ${minBetAmount} to gamble on this one");
            Console.Write("\nhow much u betting? ");
            
            while (true)
            {
                try
                {
                    playerBetAmount = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("bruh, we only accept real moneies like 3 monies or something");
                }
            }

            if (playerBetAmount < minBetAmount || playerCurrency < playerBetAmount)
            {
                Console.WriteLine("\nnot enough money bub");
                ExitGame();
            }
            else
            {
                Console.WriteLine("alright");

                Random random = new Random();
                
                double percentage = random.Next(5, 50) / 100.0;
                int direction = random.Next(0, 2) == 0 ? 1 : -1;
                npcBetAmount = playerBetAmount + (int)(playerBetAmount * percentage * direction);
                
                Console.WriteLine($"the guy ur up against threw ${npcBetAmount} on the table");

                Start();
            }
        }

        public void ExitGame()
        {
            Console.WriteLine("ok, we done gambling on this one");
        }

        public void ChangeCurrency(int amount, bool hasWon=true)
        {
            if (hasWon)
            {
                _player.ChangeCurrency(npcBetAmount);
            }
            else
            {
                _player.ChangeCurrency(-playerBetAmount);
            }
        }

        public int GetNPCBetAmount()
        {
            return npcBetAmount;
        }

        public int GetPlayerBetAmount()
        {
            return playerBetAmount;
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public abstract void Start();
    }
}