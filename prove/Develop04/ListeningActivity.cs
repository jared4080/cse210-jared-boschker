using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace Develop04
{    
    public class ListeningActivity : Activity
    {
        List<string> prompts = new List<string>
        {
            "why are you feeling how you are right now?",
            "look at the people around you, and guess their names",
            "I really want ice cream right now :drooling_emoji: what are things you are craving?"
        };

        public ListeningActivity(string activityName) : base(activityName)
        {
            
        }

        public override void RunActivity()
        {
            double sessionDuration = GetDurationToComplete();

            Console.WriteLine("\nhit enter when you think of something");
            Console.WriteLine(GetRandomPrompt(prompts));

            Console.WriteLine("get ready!!!!!!!!");
            Timer beginTimer = new Timer(3.0);
            beginTimer.WaitForTimeout();

            Timer sessionTimer = new Timer(sessionDuration);

            while (!sessionTimer.IsFinished())
            {
                Console.Write("-");
                Console.ReadLine();
            }

            DisplayMessage(GetEndMessage());
        }
    }
}