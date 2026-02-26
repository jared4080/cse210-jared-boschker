using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace Develop04
{    
    public class ReflectionActivity : Activity
    {
        List<string> prompts = new List<string>
        {
            "think of a time where you wanted to eat",
            "what are some things in life that make you mad?",
            "what are the craziest times you've gotten sick?"
        };

        
        public ReflectionActivity(string activityName, double duration) : base(activityName, duration)
        {
            
        }

        public override void RunActivity()
        {   
            double waitDuration = 5.0;

            Console.WriteLine(GetRandomPrompt(prompts));

            Console.WriteLine("\nhit enter when you've got something to say about this");
            Console.ReadLine();

            Console.WriteLine("\nnow ponder on the upcoming questions as they relate to the prompt");
            Timer timer = new Timer(waitDuration);
            timer.WaitForTimeout(waitDuration);

            Console.WriteLine("\nhow did you feel when that happened?");
            timer.WaitForTimeout(waitDuration);
            Console.WriteLine("\nhow did you survive when that happened?");
            timer.WaitForTimeout(waitDuration);
            Console.WriteLine("\nhow did this happen to you?");
            timer.WaitForTimeout(waitDuration);

            Console.WriteLine("\n\nyou did good!!");
            timer.WaitForTimeout(waitDuration);

            DisplayMessage(GetEndMessage());
        }
    }
}