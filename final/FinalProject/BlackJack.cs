using System;


namespace FinalProject
{    
    public class BlackJack : Game
    {
        double playerValue = 0;
        double dealerValue = 0;

        bool playerHasStood = false;
        bool dealerHasStood = false;

        Random random = new Random();
        Timer timer = new Timer(5);

        public BlackJack(Player player) : base(player)
        {
            SetAmountToStart(20);
        }


        public override void Start()
        {
            InitializeCards();

            while (true)
            {
                if (!playerHasStood)
                {
                    PlayerDraw();
                }

                if (playerValue > 21)
                {
                    break;
                }

                if (!DealerHasStood())
                {
                    DealerDraw();
                }

                if (dealerValue > 21)
                {
                    break;
                }

                if (playerHasStood && dealerHasStood)
                {
                    break;
                }
            }

            timer.WaitForTimeout(3);

            Console.WriteLine($"the dealer lays down {dealerValue}");

            if (playerValue > 21)
            {
                Console.WriteLine($"you went over with {playerValue} and the dealer gets to take ur bet");
                PlayerLose(GetPlayerBetAmount());
            }
            else if (dealerValue > 21)
            {
                Console.WriteLine($"the dealer went over with {dealerValue} and you got all his money from the bet :P");
                PlayerWin(GetNPCBetAmount());
            }
            else if (playerValue > dealerValue)
            {
                Console.WriteLine("HAH u win! in ur face dealer!!");
                PlayerWin(GetNPCBetAmount());
            }
            else if (dealerValue > playerValue)
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
            timer.WaitForTimeout(5, "the dealer is dealing");

            dealerValue += DrawCard();
            int visibleCard = DrawCard();
            dealerValue += visibleCard;

            playerValue += DrawCard();
            int playerVisibleCard = DrawCard();
            playerValue += playerVisibleCard;
            ShowPlayerAmount();

            timer.WaitForTimeout(3);
            Console.WriteLine($"\nthe dealers face up card is {visibleCard}");

            Console.WriteLine($"hit enter to show the dealer ur card");
            Console.ReadLine();
            Console.WriteLine($"you showed the dealer your {visibleCard}");
        }

        public bool DealerHasStood()
        {
            return dealerHasStood;
        }

        public void PlayerDraw()
        {
            Console.Write($"hit? (y/n): ");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                playerValue += DrawCard();
                ShowPlayerAmount();
            }
            else
            {
                playerHasStood = true;
            }
        }

        public void ShowPlayerAmount()
        {
            Console.WriteLine($"you currently have {playerValue}");
        }

        public void DealerDraw()
        {
            timer.WaitForTimeout(3, "");
            if (dealerValue < 17)
            {
                dealerValue += DrawCard();
                Console.WriteLine("the dealer hit");
            }
            else
            {
                dealerHasStood = true;
                Console.WriteLine("the dealer stands");
            }
        }

        public int DrawCard()
        {
            int cardDrawn = random.Next(1, 11);

            return cardDrawn;
        }
    }
}