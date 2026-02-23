using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace Develop04
{    
    public class BreathingActivity : Activity
    {
        double breathInDuration = 5.0;
        double breathOutDuration = 5.0;

        public BreathingActivity(string activityName, double duration) : base(activityName, duration)
        {
            
        }

        public override void RunActivity()
        {
            
        }
    }
}