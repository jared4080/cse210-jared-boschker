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

            Console.WriteLine($"\nthe dealer has {dealerValue}, and you have {playerValue}");

            if (playerValue > 21)
            {
                Console.WriteLine("you lost");
            }
            else if (dealerValue > 21)
            {
                Console.WriteLine("dealer lost");
            }
            else if (playerValue > dealerValue)
            {
                Console.WriteLine("you win");
            }
            else
            {
                Console.WriteLine("no one won");
            }
        }

        public void InitializeCards()
        {
            dealerValue += DrawCard();

            int visibleCard = DrawCard();
            dealerValue += visibleCard;

            playerValue += DrawCard();
            int playerVisibleCard = DrawCard();
            playerValue += playerVisibleCard;
            ShowPlayerAmount();

            Console.WriteLine($"the dealers face up card is {visibleCard}");
            Console.WriteLine($"\nyou showed the dealer your {visibleCard}");
        }

        public bool DealerHasStood()
        {
            return dealerHasStood;
        }

        public void PlayerDraw()
        {
            Console.WriteLine($"hit? (y/n): ");
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
            if (dealerValue < 17)
            {
                dealerValue += DrawCard();
                Console.WriteLine("the dealer hit");
            }
            else
            {
                dealerHasStood = true;
                Console.WriteLine("the dealer has stood");
            }
        }

        public int DrawCard()
        {
            int cardDrawn = random.Next(1, 11);

            return cardDrawn;
        }
    }
}