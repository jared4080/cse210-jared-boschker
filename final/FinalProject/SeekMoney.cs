using System;
using System.Security.Cryptography;
using System.Threading.Channels;


namespace FinalProject
{    
    public class SeekMoney : Game
    {
        Random random = new Random();
        Timer timer = new Timer(5);

        List<string> foundMessages = new List<string>{
            "you found money on the ground!!",
            "you found a wallet",
            "you took a bit of cash from someones pocket",
        };

        public SeekMoney(Player player, bool isBet=false) : base(player, isBet)
        {
            
        }

        public override void Start()
        {
            timer.WaitForTimeout(5, "you start looking for money");

            int chances = random.Next(0, 6);

            if (chances == 0)
            {
                Console.WriteLine("you didn't find any money");
            }
            else
            {
                string randomMessage = foundMessages[random.Next(foundMessages.Count)];
                Console.WriteLine(randomMessage);

                Console.WriteLine();

                int moneyAmountFound = random.Next(2, 6);

                PlayerWin(moneyAmountFound);
            }
        }
    }
}