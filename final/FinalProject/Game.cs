using System;
using System.Runtime.CompilerServices;


namespace FinalProject
{    
    public abstract class Game
    {
        int _currencyToStart = 0;
        int _minBetAmount = 0;
        int _playerBetAmount = 0;

        int _npcBetAmount = 0;

        Player _player;


        public Game(Player player, bool isBet=true)
        {
            _player = player;

            if (_player.GetMoneyAmount() >= _currencyToStart)
            {                
                if (isBet)
                {
                    PlaceBet(_player.GetMoneyAmount());
                }
                else
                {
                    Start();
                }
            }
            else
            {
                Console.WriteLine($"you gotta have at least ${_minBetAmount} to gamble on this one");
                ExitGame();
            }
        }


        public int GetCurrencyToStart()
        {
            return _currencyToStart;
        }

        public void PlaceBet(int playerCurrency)
        {
            Console.Write("\nhow much u betting? ");
            
            while (true)
            {
                try
                {
                    _playerBetAmount = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("bruh, we only accept real moneies like 3 monies or something");
                }
            }

            if (_playerBetAmount < _minBetAmount || playerCurrency < _playerBetAmount)
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
                _npcBetAmount = _playerBetAmount + (int)(_playerBetAmount * percentage * direction);
                
                Console.WriteLine($"the guy ur up against threw ${_npcBetAmount} on the table");

                Start();
            }
        }

        public void ExitGame()
        {
            Console.WriteLine("ok, we done gambling on this one");
        }

        public void SetAmountToStart(int amount)
        {
            _minBetAmount = amount;
        }

        public void PlayerWin(int amount)
        {
            _player.ChangeCurrency(amount);
        }

        public void PlayerLose(int amount)
        {
            _player.ChangeCurrency(-amount);
        }

        public int GetNPCBetAmount()
        {
            return _npcBetAmount;
        }

        public int GetPlayerBetAmount()
        {
            return _playerBetAmount;
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public abstract void Start();
    }
}