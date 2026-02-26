using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Xml;


namespace Develop04
{    
    public class RedGreenLightActivity : Activity
    {        
        double _minChangeTime = 3.0;
        double _maxChangeTime = 10.0;

        string _greenLightMessage = "green light :P";
        string _redLightMessage = "red light :)";

        
        public RedGreenLightActivity(string activityName) : base(activityName)
        {
            
        }

        public double GetRandomDoubleRange(double minChangeTime, double maxChangeTime)
        {
            Random random = new Random();
            
            double randomNumber = random.NextDouble() * (maxChangeTime - minChangeTime) + minChangeTime;

            return randomNumber;
        }

        public override void RunActivity()
        {   
            double beginDuration = 5.0;

            double sessionDuration = GetDurationToComplete();

            Console.WriteLine("\nget ready for a good game of red light green light haha");
            Timer beingTimer = new Timer(beginDuration);
            beingTimer.WaitForTimeout(beginDuration);

            Timer sessionTimer = new Timer(sessionDuration);

            Console.WriteLine(_greenLightMessage);

            while (!sessionTimer.IsFinished())
            {
                Timer redGreenLightTimer = new Timer(GetRandomDoubleRange(_minChangeTime, _maxChangeTime));
                
                redGreenLightTimer.WaitForTimeout(GetRandomDoubleRange(_minChangeTime, _maxChangeTime));
                Console.WriteLine(_redLightMessage);

                redGreenLightTimer.WaitForTimeout(GetRandomDoubleRange(_minChangeTime, _maxChangeTime));
                Console.WriteLine(_greenLightMessage);
            }

            DisplayMessage(GetEndMessage());
        }
    }
}