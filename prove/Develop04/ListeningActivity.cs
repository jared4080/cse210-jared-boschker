using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace Develop04
{    
    public class ListeningActivity : Activity
    {
        double breathInDuration = 5.0;
        double breathOutDuration = 5.0;

        public ListeningActivity(string activityName, double duration) : base(activityName, duration)
        {
            
        }

        public override void RunActivity()
        {
            // STARTS countdown
            // PROMPT for entries
        }
    }
}