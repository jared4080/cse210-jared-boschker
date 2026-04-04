using System;


namespace FinalProject
{    
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.GetMoneyAmount();

            bool _hasQuit = false;
            
            while (!_hasQuit)
            {
                Console.WriteLine("\ntime to gamble!! :D");
                Console.WriteLine("(1) baccrat\n(2) black jack\n(3) 3 card poker\n(4) roulette\n(5) quit");
                Console.Write("\nwhich one? ");
                string userChoice = Console.ReadLine();
                
                Console.WriteLine("");

                switch (userChoice)
                {
                    case "1":
                        Baccarat baccarat = new Baccarat();
                        baccarat.Start();
                        break;
                    case "2":
                        BlackJack blackJack = new BlackJack();
                        blackJack.Start();
                        break;
                    case "3":
                        CardPoker cardPoker = new CardPoker();
                        cardPoker.Start();
                        break;
                    case "4":
                        Roulette roulette = new Roulette();
                        roulette.Start();
                        break;
                    case "5":
                        _hasQuit = true;
                        Console.WriteLine("you left the casino :(");
                        break;
                }
            }
        }
    }
}