using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace Develop04
{    
    class Activity
    {
        string _activityName = "";
        string _startMessage = "";
        string _endMessage = "";

        double _duration = 5.0;

        public Activity (string activityName, double duration)
        {
            _activityName = activityName;
            _duration = duration;
        }

        void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        void DisplayRandomPrompt(List<string> prompts)
        {
            Random random = new Random();
            
            string randomPrompt = prompts[random.Next(prompts.Count)];
        }

        void WaitUntilFinished(double duration)
        {
            
        }

        double GetUserDouble()
        {
            double userNumber = 0.0;

            while (true)
            {        
                try
                {                
                    Console.Write("give number: ");
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
    }
}