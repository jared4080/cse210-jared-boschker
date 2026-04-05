using System;


namespace FinalProject
{    
    public class KingJared : Game
    {
        Random _random = new Random();
        Timer _timer = new Timer(3);


        public KingJared(Player player, int amountToStart) : base(player, amountToStart)
        {
            SetAmountToStart(100);
        }

        public override void Start()
        {
            Console.WriteLine("you challenge the casino owner jared");
            _timer.WaitForTimeout(2);
            Console.WriteLine("jared accepts");
            _timer.WaitForTimeout(2);
            Console.WriteLine("if you win, jared will give you the casino and everything in it");
            Console.WriteLine("\nwho ever rolls closest to 7 with 2 die wins");

            _timer.WaitForTimeout(2);
            Console.Write("\nhit enter to roll 2 die");
            Console.ReadLine();

            _timer.WaitForTimeout(3, "rolling the die");

            
            int firstNum = _random.Next(1, 7);
            int secondNum = _random.Next(1, 7);

            Console.WriteLine($"you rolled a {firstNum} and a {secondNum}");

            Console.WriteLine();
            _timer.WaitForTimeout(3, "jared is rolling the die");

            int firstNum2 = 3;
            int secondNum2 = 4;

            Console.WriteLine($"jared rolled a {firstNum2} and a {secondNum2}");

            int playerTotal = firstNum + secondNum;
            int jaredTotal = firstNum2 + secondNum2;

            int playerDiff = Math.Abs(playerTotal - 7);
            int jaredDiff = Math.Abs(jaredTotal - 7);


            _timer.WaitForTimeout(2);


            if (playerDiff < jaredDiff)
            {
                Console.WriteLine("you beat jared and are now the new casino owner!! :D");
                PlayerWin(GetNPCBetAmount());
            }
            else if (jaredDiff < playerDiff)
            {
                Console.WriteLine("should've known jared would win...");
                PlayerLose(GetPlayerBetAmount());
            }
            else
            {
                Console.WriteLine("it was a tie and no one lost anything");
            }
        }
    }
}