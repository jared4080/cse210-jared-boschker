using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace Develop04
{    
    class ReflectionActivity : Activity
    {
        double breathInDuration = 5.0;
        double breathOutDuration = 5.0;

        public ReflectionActivity(string activityName, double duration) : base(activityName, duration)
        {
            
        }

        void Reflect()
        {
            // LOOP
                // DISPLAY random prompt
                // GET user input
                // WAIT for timer to exit loop
        }
    }
}