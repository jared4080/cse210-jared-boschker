using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Develop05
{
    public abstract class ChecklistGoal : Goal
    {
        bool _hasCompletedOnce = false;

        int _bonusPointsAmount = 0;
        bool _hasReceivedBonus = false;
        
        int _timesCompleted = 0;
        int _checkAmount = 0;

        public ChecklistGoal() : base()
        {
            while (true)
            {                
                try
                {
                    Console.WriteLine("how many times would you need to complete this goal for bonus points? ");
                    _checkAmount = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("how many bonus points will you gain after completing the bonus goal?");
                    _bonusPointsAmount = Int32.Parse(Console.ReadLine());

                    break;
                }
                catch
                {
                    Console.WriteLine("one or both of your inputs were invalid (input a whole number)");
                }
            }
        }

        public override void Complete()
        {
            if (!_hasCompletedOnce)
            {
                _hasCompletedOnce = true;
            }

            if (_timesCompleted >= _checkAmount && !_hasReceivedBonus)
            {
                // ADD bonus points to points
                _hasReceivedBonus = true;
                SetCompleted();
            }
        }
    }
}