using System;
using System.Runtime.InteropServices;

namespace Develop05
{
    public class GoalManager
    {
        List<Goal> goals = new List<Goal>();


        public void SaveGoals()
        {
            Console.Write("what would you like to name the save file? ");
            string saveFile = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(saveFile))
            {
                foreach (Goal goal in goals)
                    writer.WriteLine(goal.GetGoalInfo());
            }

            Console.WriteLine($"saved {goals.Count} goals to {saveFile}");
        }

        public void LoadGoals()
        {
            Console.Write("where would you like to load your entries from?");
            string fileName = Console.ReadLine();

            if (!File.Exists(fileName))
            {
                Console.WriteLine(fileName);
                return;
            }

            goals.Clear();

            foreach (string line in File.ReadAllLines(fileName))
            {
                string[] parts = line.Split(" ");
                switch (parts[0])
                {
                    case "SimpleGoal":
                        goals.Add(new SimpleGoal());
                        break;
                    case "EternalGoal":
                        goals.Add(new EternalGoal());
                        break;
                    case "ChecklistGoal":
                        goals.Add(new ChecklistGoal());
                        break;
                }
            }

            Console.WriteLine($"loaded {goals.Count} goals");
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
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"({i + 1}) {goals[i].GetGoalInfo()}");
            }
        }

        public int RecordEvent()
        {
            ListGoals();

            Console.WriteLine("what goal would you like to complete? ");
            int goalIndex = Int32.Parse(Console.ReadLine()) - 1;

            if (goalIndex < 0 || goalIndex >= goals.Count)
            {
                Console.WriteLine("invalid goal number");
                return 0;
            }

            Goal selectedGoal = goals[goalIndex];
            

            if (!selectedGoal.GetIsCompleted()){
                selectedGoal.SetCompleted();
                return selectedGoal.Complete();
            }
            else
            {
                Console.WriteLine("goal has already been completed");
                return 0;
            }
        }
    }
}