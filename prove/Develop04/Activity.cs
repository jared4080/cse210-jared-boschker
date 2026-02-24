using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace Develop04
{    
    public abstract class Activity
    {
        string _activityName = "";
        string _startMessage = "start message hahaa\n";
        string _endMessage = "\n\nend message nono";

        double _duration = 5.0;

        public Activity (string activityName, double duration)
        {
            _activityName = activityName;
            _duration = duration;

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