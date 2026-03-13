using System;

namespace Develop05
{
    public class GoalManager
    {
        List<Goal> goals = new List<Goal>();


        public void SaveGoals()
        {
            
        }

        public void LoadGoals()
        {
            
        }

        public void CreateGoal()
        {
            Console.WriteLine("what type of goal would you like to create?");
            Console.WriteLine("(1) simple\n(2) eternal\n(3) check list");

            Console.Write("okay, so what goal is it gonna be? ");
            string userChoice = Console.ReadLine();

            Console.WriteLine();


            switch (userChoice)
            {
                case "1":
                    SimpleGoal simpleGoal = new SimpleGoal();
                    goals.Add(simpleGoal);
                    break;
                case "2":
                    EternalGoal eternalGoal = new EternalGoal();
                    goals.Add(eternalGoal);
                    break;
                case "3":
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    goals.Add(checklistGoal);
                    break;
            }
        }

        public void ListGoals()
        {
            Console.WriteLine("okay, here are all the goals!!");
            foreach (Goal goal in goals)
            {
                Console.WriteLine(goal.GetGoalInfo());
            }
        }

        public int RecordEvent()
        {
            ListGoals();

            Console.Write("which goal would you like to complete? ");
            int goalToComplete = Int32.Parse(Console.ReadLine());

            Goal selectedGoal = goals[goalToComplete];

            return selectedGoal.GetPointsAmount(); 
        }
    }
}