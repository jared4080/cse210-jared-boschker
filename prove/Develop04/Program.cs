using System;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            // BreathingActivity breathingActivity = new BreathingActivity("breath", 5.0);
            // breathingActivity.RunActivity();

            // ReflectionActivity reflectionActivity = new ReflectionActivity("reflect", 5.0);
            // reflectionActivity.RunActivity();

            ListeningActivity listeningActivity = new ListeningActivity("listen", 5.0);
            listeningActivity.RunActivity();

            
        }
    }
}