using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace Develop04
{    
    public class BreathingActivity : Activity
    {
        double breathDuration = 5.0;

        public BreathingActivity(string activityName, double duration) : base(activityName, duration)
        {
            
        }

        public override void RunActivity()
        {
            double activityDuration = GetUserDouble("how many seconds do you wanna do breathing stuff for? ");
            Console.WriteLine("okay bet");

            DateTime endTime = DateTime.Now.AddSeconds(activityDuration);

            Timer finishTimer = new Timer(activityDuration);
            
            while (!finishTimer.IsFinished())
            {

                Timer breathInTimer = new Timer(breathDuration);
                Console.WriteLine("\nBREATH IN!!");
                breathInTimer.WaitForTimeout();

                Timer breathOutTimer = new Timer(breathDuration);
                Console.WriteLine("\nBREATH OUT!!");
                breathOutTimer.WaitForTimeout();
                
                Console.WriteLine();
            }

            DisplayMessage(GetEndMessage());
        }
    }
}