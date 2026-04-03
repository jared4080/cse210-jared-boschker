using System;


namespace FinalProject
{    
    public abstract class Game
    {
        static void Main(string[] args)
        {
            
        }

        int currencyToStart;
        int minBetAmount;
        int playerBetAmount;
        int numberOfGamblers;

        string startMessage;

        double chancesOfWinning;


        public int GetCurrencyToStart()
        {
            return currencyToStart;
        }

        public void PlaceBet()
        {
            
        }

        public void ExitGame()
        {
            
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public abstract void Start();
    }
}