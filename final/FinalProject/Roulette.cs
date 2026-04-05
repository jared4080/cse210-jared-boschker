using System;


namespace FinalProject
{    
    public class Roulette : Game
    {
        bool _hasBetOnBlack = true;

        public Roulette(Player player) : base(player)
        {
            SetAmountToStart(50);
        }

        public override void Start()
        {
            Timer timer = new Timer(5);
            Random random = new Random();

            Console.Write("bet on black or red? (b/r): ");
            string playerBet = Console.ReadLine();

            if (playerBet == "b")
            {
                _hasBetOnBlack = true;
            }
            else
            {
                _hasBetOnBlack = false;
            }

            Console.WriteLine("hit enter to spin the wheel");
            Console.ReadLine();

            timer.WaitForTimeout(5, "the wheel is spinning");
            timer.WaitForTimeout(5, "the ball is balling");


            int redOrBlack = random.Next(0, 1);

            if (_hasBetOnBlack && redOrBlack == 1)
            {
                Console.WriteLine("yay, it landed on black!!");
                PlayerWin(GetNPCBetAmount());
            }
            else if (!_hasBetOnBlack && redOrBlack == 0)
            {
                Console.WriteLine("yay, it landed on red!!");
                PlayerWin(GetNPCBetAmount());
            }
            else if (!_hasBetOnBlack && redOrBlack == 1)
            {
                Console.WriteLine("it landed on black... you should've bet on black");
                PlayerLose(GetPlayerBetAmount());
            }
            else if (_hasBetOnBlack && redOrBlack == 0)
            {
                Console.WriteLine("brooo why did it land on red??");
                PlayerLose(GetPlayerBetAmount());
            }
        }
    }
}