using System;
using Develop05;

class Program
{
    static void Main(string[] args)
    {
        bool _hasQuit = false;


        while (!_hasQuit)
        {            
            Console.WriteLine("\nlook at all the activities!");
            Console.WriteLine("(1) create new goal\n(2) list goals\n(3) save goals\n(4) load goals\n(5) record event\n(6) quit");
            Console.Write("\nwhat would you like to do? ");
            string userChoice = Console.ReadLine();
            
            Console.WriteLine("");

            GoalManager goalManager = new GoalManager();

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
                    // might need to change the way goals are recorded
                    goalManager.RecordEvent();
                    break;
                case "6":
                    _hasQuit = true;
                    Console.WriteLine("okay, see you later! :D");
                    break;
            }
        }
    }
}