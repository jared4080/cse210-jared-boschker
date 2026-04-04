using System;
using System.Formats.Asn1;


namespace FinalProject
{    
    public class BlackJack : Game
    {
        double chancesForBJ = 4.8;
        double currentNumber = 0;
        double dealerNumber = 0;

        bool hasDealerStood = false;

        public override void Start()
        {
            while (true)
            {
                currentNumber += DrawCard();
                currentNumber += DrawCard();
                Console.WriteLine($"you currently have {currentNumber}");
                
                Console.WriteLine($"hit? (y/n): ");
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    currentNumber += DrawCard();
                }
                else
                {
                    if (currentNumber > 21)
                    {
                        Console.WriteLine($"uh oh, you went {currentNumber - 21} over and lost your monies");
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }

        public void Dealer()
        {
            dealerNumber += DrawCard();
            dealerNumber += DrawCard();

            if (dealerNumber < 9)
            {
                dealerNumber += DrawCard();
            }
        }

        public bool DealerHasStood()
        {
            
        }

        

        public int DrawCard()
        {
            Random random = new Random();
            int cardDrawn = random.Next(1, 10);

            return cardDrawn;
        }
    }
}