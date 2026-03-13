using System;


namespace Develop05
{    
    class Program
    {
        static void Main(string[] args)
        {
            int pointsAmount = 0;
            
            bool _hasQuit = false;

            GoalManager goalManager = new GoalManager();

            while (!_hasQuit)
            {            
                Console.WriteLine("\nlook at all the activities!");
                Console.WriteLine("(1) create new goal\n(2) list goals\n(3) save goals\n(4) load goals\n(5) record event\n(6) quit");
                Console.Write("\nwhat would you like to do? ");
                string userChoice = Console.ReadLine();
                
                Console.WriteLine("");

                switch (userChoice)
                {
                    case "1":
                        goalManager.CreateGoal();
                        break;
                    case "2":
                        goalManager.ListGoals();
                        break;
                    case "3":
                        goalManager.SaveGoals();
                        break;
                    case "4":
                        goalManager.LoadGoals();
                        break;
                    case "5":
                        int pointsToAdd = goalManager.RecordEvent();
                        pointsAmount += pointsToAdd;
                        Console.WriteLine($"\n{pointsAmount}\n");
                        break;
                    case "6":
                        _hasQuit = true;
                        Console.WriteLine("okay, see you later! :D");
                        break;
                }
            }
        }
    }
}