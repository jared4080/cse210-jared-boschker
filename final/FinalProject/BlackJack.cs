using System;


namespace FinalProject
{    
    public class BlackJack : Game
    {
        double _playerValue = 0;
        double _dealerValue = 0;

        bool _playerHasStood = false;
        bool _dealerHasStood = false;

        Random _random = new Random();
        Timer _timer = new Timer(5);

        public BlackJack(Player player, int amountToStart) : base(player, amountToStart)
        {
            
        }


        public override void Start()
        {
            InitializeCards();

            while (true)
            {
                if (!_playerHasStood)
                {
                    PlayerDraw();
                }

                if (_playerValue > 21)
                {
                    break;
                }

                if (!DealerHasStood())
                {
                    DealerDraw();
                }

                if (_dealerValue > 21)
                {
                    break;
                }

                if (_playerHasStood && _dealerHasStood)
                {
                    break;
                }
            }

            _timer.WaitForTimeout(3);

            Console.WriteLine($"the dealer lays down {_dealerValue}");

            if (_playerValue > 21)
            {
                Console.WriteLine($"you went over with {_playerValue} and the dealer gets to take ur bet");
                PlayerLose(GetPlayerBetAmount());
            }
            else if (_dealerValue > 21)
            {
                Console.WriteLine($"the dealer went over with {_dealerValue} and you got all his money from the bet :P");
                PlayerWin(GetNPCBetAmount());
            }
            else if (_playerValue > _dealerValue)
            {
                Console.WriteLine("HAH u win! in ur face dealer!!");
                PlayerWin(GetNPCBetAmount());
            }
            else if (_dealerValue > _playerValue)
            {
                Console.WriteLine("uh oh, the dealer won and took all the money you bet!!");
                PlayerLose(GetPlayerBetAmount());
            }
            else
            {
                Console.WriteLine("no one won, u both get to keep ur bets");
            }
        }

        public void InitializeCards()
        {
            _timer.WaitForTimeout(5, "the dealer is dealing");

            _dealerValue += DrawCard();
            int visibleCard = DrawCard();
            _dealerValue += visibleCard;

            _playerValue += DrawCard();
            int playerVisibleCard = DrawCard();
            _playerValue += playerVisibleCard;
            ShowPlayerAmount();

            _timer.WaitForTimeout(3);
            Console.WriteLine($"\nthe dealers face up card is {visibleCard}");

            Console.WriteLine($"hit enter to show the dealer ur card");
            Console.ReadLine();
            Console.WriteLine($"you showed the dealer your {playerVisibleCard}");
        }

        public bool DealerHasStood()
        {
            return _dealerHasStood;
        }

        public void PlayerDraw()
        {
            Console.Write($"hit? (y/n): ");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                _playerValue += DrawCard();
                ShowPlayerAmount();
            }
            else
            {
                _playerHasStood = true;
            }
        }

        public void ShowPlayerAmount()
        {
            Console.WriteLine($"you currently have {_playerValue}");
        }

        public void DealerDraw()
        {
            _timer.WaitForTimeout(3, "");
            if (_dealerValue < 17)
            {
                _dealerValue += DrawCard();
                Console.WriteLine("the dealer hit");
            }
            else
            {
                _dealerHasStood = true;
                Console.WriteLine("the dealer stands");
            }
        }

        public int DrawCard()
        {
            int cardDrawn = _random.Next(1, 11);

            return cardDrawn;
        }
    }
}