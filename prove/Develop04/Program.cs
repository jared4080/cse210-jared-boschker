using System;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            BreathingActivity breathingActivity = new BreathingActivity("breath", 5.0);
            breathingActivity.RunActivity();
        }
    }
}