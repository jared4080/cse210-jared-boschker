using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace Develop04
{    
    public class ListeningActivity : Activity
    {
        List<string> prompts = new List<string>
        {
            "think of a time where you wanted to eat",
            "what are some things in life that make you mad?",
            "what are the craziest times you've gotten sick?"
        };

        public ListeningActivity(string activityName, double duration) : base(activityName, duration)
        {
            
        }

        public override void RunActivity()
        {
            GetUserDouble("hah");
            Console.WriteLine(GetRandomPrompt(prompts));
            Console.WriteLine("\nhit enter when you think of something");
            Console.ReadLine();
            // STARTS countdown
            // PROMPT for entries
            DisplayMessage(GetEndMessage());
        }
    }
}