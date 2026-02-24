using System;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Develop04 World!");

            BreathingActivity breathingActivity = new BreathingActivity("breath", 5.0);
            breathingActivity.RunActivity();

        }
        
    }
}