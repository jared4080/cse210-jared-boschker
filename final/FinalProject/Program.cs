using System;


namespace FinalProject
{    
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.GetMoneyAmount();

            Timer timer = new Timer(3);

            bool _hasQuit = false;
            
            while (!_hasQuit)
            {
                Console.WriteLine("\ntime to gamble!! :D");
                Console.WriteLine("(1) look for money\n(2) black jack\n(3) roulette\n(4) challenge jared\n(5) quit");
                Console.Write("\nwhich one? ");
                string userChoice = Console.ReadLine();
                
                Console.WriteLine("");

                Console.WriteLine($"you have ${player.GetCurrency()}");


                switch (userChoice)
                {
                    case "1":
                        SeekMoney seekMoney = new SeekMoney(player);
                        timer.WaitForTimeout(2);
                        break;
                    case "2":
                        BlackJack blackJack = new BlackJack(player);
                        timer.WaitForTimeout(2);
                        break;
                    case "3":
                        Roulette roulette = new Roulette(player);
                        timer.WaitForTimeout(2);
                        break;
                    case "4":
                        KingJared kingJared = new KingJared(player);
                        timer.WaitForTimeout(2);
                        break;
                    case "5":
                        Console.WriteLine("you left the casino :(");
                        _hasQuit = true;
                        break;
                }
            }
        }
    }
}