using System;


namespace FinalProject
{    
    class Program
    {

        
        static void Main(string[] args)
        {
            bool _hasQuit = false;
            
            while (!_hasQuit)
            {
                Console.WriteLine("\ntime to gamble!! :D");
                Console.WriteLine("(1) baccrat\n(2) black jack\n(3) 3 card poker\n(4) craps\n(5) roulette\n(6) quit");
                Console.Write("\nwhich one? ");
                string userChoice = Console.ReadLine();
                
                Console.WriteLine("");

                switch (userChoice)
                {
                    case "1":
                        
                        break;
                    case "2":
                        
                        break;
                    case "3":
                        
                        break;
                    case "4":
                        
                        break;
                    case "5":
                        
                        break;
                    case "6":
                        _hasQuit = true;
                        Console.WriteLine("ok fine! I guess u don't wanna gamble anymore... :(");
                        break;
                }
            }
        }

        void DisplayMenu()
        {
            
        }
    }
}