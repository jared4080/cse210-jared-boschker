using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace Develop04
{    
    public class Timer
    {
        DateTime _targetTime = DateTime.Now;

        public Timer(double duration)
        {
            _targetTime = DateTime.Now.AddSeconds(duration);
        }

        public bool IsFinished()
        {
            return DateTime.Now >= _targetTime;
        }

        public void Set(double time)
        {
            _targetTime = DateTime.Now.AddSeconds(time);
        }

        public void WaitForTimeout(string message="")
        {
            if (message != "") Console.WriteLine("\n", message);

            int i = 0;

            while (DateTime.Now < _targetTime)
            {
                i++;
                if (i > 3)
                {
                    i = 0;
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                }
                else
                {
                    Console.Write(".");
                }
                Thread.Sleep(500);
            }
        }
    }
}