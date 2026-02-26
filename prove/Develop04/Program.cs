using System;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _hasQuit = false;

            Console.WriteLine("welcome to my activities :smiley_emoji:");

            while (!_hasQuit){            
                Console.WriteLine("\nlook at all the activities!");
                Console.WriteLine("(1) breathing\n(2) listening\n(3) reflection\n(4) red light green light\n(5) quit");
                Console.Write("\nwhat would you like to do? ");
                string userChoice = Console.ReadLine();
                
                Console.WriteLine("");

                switch (userChoice)
                {
                    case "1":
                        BreathingActivity breathingActivity = new BreathingActivity("breath");
                        breathingActivity.RunActivity();
                        break;
                    case "2":
                        ListeningActivity listeningActivity = new ListeningActivity("listening");
                        listeningActivity.RunActivity();
                        break;
                    case "3":
                        ReflectionActivity reflectionActivity = new ReflectionActivity("reflect");
                        reflectionActivity.RunActivity();
                        break;
                    case "4":
                        RedGreenLightActivity redGreenLightActivity = new RedGreenLightActivity("red light green light");
                        redGreenLightActivity.RunActivity();
                        break;
                    case "5":
                        _hasQuit = true;
                        Console.WriteLine("okay, see you later! :D");
                        break;
                }
            }
        }
    }
}
