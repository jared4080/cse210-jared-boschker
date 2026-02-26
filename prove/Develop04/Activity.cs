using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace Develop04
{    
    public abstract class Activity
    {
        string _activityName = "";
        double _durationToComplete = 0.0;

        string _startMessage = "start message hahaa";
        string _endMessage = $"\n\nend message nono";

        public Activity (string activityName)
        {
            _durationToComplete = GetUserDouble("how long would you like your session to last in seconds? ");
           
            _activityName = activityName;
            _endMessage = $"\n\n wow!! you did this activity for {_durationToComplete} seconds for this {activityName} thingy";

            DisplayMessage(_startMessage);
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string GetEndMessage()
        {
            return _endMessage;
        }

        public double GetDurationToComplete()
        {
            return _durationToComplete;
        }

        public string GetRandomPrompt(List<string> prompts)
        {
            Random random = new Random();
            
            string randomPrompt = prompts[random.Next(prompts.Count)];
            return randomPrompt;
        }

        public double GetUserDouble(string prompt)
        {
            double userNumber = 0.0;

            while (true)
            {        
                try
                {                
                    Console.Write(prompt);

                    userNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("kk");

                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("invalid input");
                }
            }

            return userNumber;
        }

        public abstract void RunActivity();
    }
}