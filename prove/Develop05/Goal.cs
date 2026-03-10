using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Develop05
{
    public abstract class Goal
    {
        string _name;
        string _description;

        int _pointsAmount = 0;
        bool _isCompleted = false;

        public Goal()
        {
            Console.WriteLine("what is the name of the goal?");
            _name = Console.ReadLine();

            Console.WriteLine("write a description of the goal");
            _description = Console.ReadLine();

            while (true)
            {           
                try
                {
                    Console.WriteLine("how many points should the goal give?");
                    _pointsAmount = Int32.Parse(Console.ReadLine());
                    
                    break;
                }
                catch
                {
                    Console.WriteLine("whole number please...");
                }
            }
        }

        public void SetCompleted()
        {
            _isCompleted = true;
        }

        public bool GetIsCompleted()
        {
            return _isCompleted;
        }

        public int GetPointsAmount()
        {
            return _pointsAmount;
        }

        public abstract void Complete();
    }
}