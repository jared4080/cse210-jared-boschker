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
            Console.Write("what is the name of the goal? ");
            _name = Console.ReadLine();

            Console.Write("write a description for the goal: ");
            _description = Console.ReadLine();

            while (true)
            {           
                try
                {
                    Console.Write("how many points should the goal give? ");
                    _pointsAmount = Int32.Parse(Console.ReadLine());
                    
                    break;
                }
                catch
                {
                    Console.WriteLine("input a whole number...");
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