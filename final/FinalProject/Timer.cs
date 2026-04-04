using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace FinalProject
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

        public void WaitForTimeout(double duration=5.0, string message="")
        {
            int i = 0;

            DateTime timeoutTargetTime = DateTime.Now.AddSeconds(duration);
            Console.Write($"{message}");

            while (DateTime.Now < timeoutTargetTime)
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
            Console.WriteLine();
        }
    }
}